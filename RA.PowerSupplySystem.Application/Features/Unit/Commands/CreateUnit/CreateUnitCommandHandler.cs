using AutoMapper;
using MediatR;
using RA.PowerSupplySystem.Application.Contracts.Persistence;
using RA.PowerSupplySystem.Application.Exceptions;
using RA.PowerSupplySystem.Application.Responses;

namespace RA.PowerSupplySystem.Application.Features.Unit.Commands.CreateUnit
{
    public class CreateUnitCommandHandler : IRequestHandler<CreateUnitCommand, BaseCommandResponse>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly IOrderDetailRepository _orderDetailRepository;

        public CreateUnitCommandHandler(IUnitRepository unitRepository, IProductRepository productRepository,
            IOrderRepository orderRepository, IMapper mapper, IOrderDetailRepository orderDetailRepository)
        {
            _unitRepository = unitRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _mapper = mapper;
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<BaseCommandResponse> Handle(CreateUnitCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateUnitCommandValidator(_unitRepository, _productRepository, _orderRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Unidad Invalida", validationResult);
            }

            var orderUnits = await _unitRepository.GetAllOrderUnitsByProduct(request.OrderId, request.ProductId);

            var requiredProductQty = _orderDetailRepository.GetOrderProductQuantity(request.OrderId, request.ProductId);

            if(requiredProductQty < 1)
            {
                throw new BadRequestException($"La orden con Id '{request.OrderId}' no requiere el producto con Id '{request.ProductId}'");
            }

            if(orderUnits.Count >= requiredProductQty)
            {
                throw new BadRequestException($"No se pueden agregar más unidades de este producto a la orden con Id '{request.OrderId}'");
            }

            var unit = _mapper.Map<Domain.Unit>(request);
            unit.SerialNumber = Guid.NewGuid().ToString();

            await _unitRepository.CreateAsync(unit);

            return new BaseCommandResponse
            {
                Id = unit.Id,
                Message = "Unidad creada exitosamente",
                Success = true
            };
        }
    }
}
