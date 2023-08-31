using AutoMapper;
using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using RA.PowerSupplySystem.Application.Exceptions;
using RA.PowerSupplySystem.Application.Models;
using RA.PowerSupplySystem.Application.Responses;
using RA.PowerSupplySystem.Application.Responses.Orders;
using RA.PowerSupplySystem.Domain;

namespace RA.PowerSupplySystem.Application.Features.Order.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IProductMaterialRepository _productMaterialRepository;
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;
        private List<Domain.Material> usedMaterials = new List<Domain.Material>();

        public CreateOrderCommandHandler(IProductRepository productRepository, IOrderDetailRepository orderDetailRepository,
            IOrderRepository orderRepository, IProductMaterialRepository productMaterialRepository,
            IMaterialRepository materialRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _orderDetailRepository = orderDetailRepository;
            _orderRepository = orderRepository;
            _productMaterialRepository = productMaterialRepository;
            _materialRepository = materialRepository;
            _mapper = mapper;
        }
        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateOrderCommandValidator(_productRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Orden Invalida", validationResult);
            }

            var products = await _productRepository.GetAllAsync();
            var productsMaterials = await _productMaterialRepository.GetProductsMaterials();

            var order = new Domain.Order
            {
                OrderDate = DateTime.Now,
                Total = 0
            };
            var orderDetails = new List<Domain.OrderDetail>();

            foreach (var detail in request.Products)
            {
                var requiredMaterials = productsMaterials.Where(q => q.ProductId == detail.ProductId).ToList();
                var insufficientMaterials = SubstractMaterials(requiredMaterials, detail.Quantity);
                if (insufficientMaterials.Any())
                {
                    return new CreateOrderCommandResponse
                    {
                        Message = "No hay suficientes materiales para esta orden",
                        Id = 0,
                        Success = false,
                        InsufficientMaterials = insufficientMaterials
                    };
                }
                var orderDetail = _mapper.Map<Domain.OrderDetail>(detail);
                order.Total += orderDetail.Quantity * products.First(p => p.Id == orderDetail.ProductId).Price;
                orderDetails.Add(orderDetail);
            }

            await _materialRepository.UpdateMaterials(usedMaterials);

            await _orderRepository.CreateAsync(order);

            foreach (var detail in orderDetails)
            {
                detail.OrderId = order.Id;
            }

            await _orderDetailRepository.AddOrderDetails(orderDetails);

            return new CreateOrderCommandResponse
            {
                Id = order.Id,
                Message = "Orden creada exitosamente",
                Success = true
            };
        }

        private List<InsufficientMaterialDetail> SubstractMaterials(List<ProductMaterial> productMaterials, int productQuantity)
        {
            List<InsufficientMaterialDetail> insufficientMaterials = new List<InsufficientMaterialDetail>();
            foreach (var productMat in productMaterials)
            {
                int materialNeeded = productQuantity * productMat.Quantity;
                if (materialNeeded > productMat.Material.Stock)
                {
                    //insufficientMaterials.Add($"No hay suficiente material ({productMat.Material.Name})");
                    insufficientMaterials.Add(new InsufficientMaterialDetail
                    {
                        Id = productMat.Material.Id,
                        Name = productMat.Material.Name,
                        AvailableQty = productMat.Material.Stock,
                        RequiredQty = materialNeeded
                    });
                    continue;
                }
                productMat.Material.Stock -= materialNeeded;
                if (!usedMaterials.Contains(productMat.Material))
                {
                    usedMaterials.Add(productMat.Material);
                }
            }
            return insufficientMaterials;
        }
    }
}
