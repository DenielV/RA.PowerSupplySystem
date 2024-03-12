using FluentValidation;
using RA.PowerSupplySystem.Application.Contracts.Persistence;

namespace RA.PowerSupplySystem.Application.Features.Unit.Commands.CreateUnit
{
    public class CreateUnitCommandValidator : AbstractValidator<CreateUnitCommand>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;

        public CreateUnitCommandValidator(IUnitRepository unitRepository, IProductRepository productRepository, 
            IOrderRepository orderRepository)
        {
            _unitRepository = unitRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;

            RuleFor(q => q.ProductId)
                .NotNull().WithMessage("El campo {PropertyName} es obligatorio.")
                .MustAsync(ProductMustExist).WithMessage("El producto con Id '{PropertyValue}' no existe");

            RuleFor(q => q.OrderId)
               .NotNull().WithMessage("El campo {PropertyName} es obligatorio.")
               .MustAsync(OrderMustExist).WithMessage("La orden con Id '{PropertyValue}' no existe");
        }

        private async Task<bool> OrderMustExist(int orderId, CancellationToken token)
        {
            var order = await _orderRepository.GetAsync(orderId);
            return order != null;
        }

        private async Task<bool> ProductMustExist(int productId, CancellationToken token)
        {
            var product = await _productRepository.GetAsync(productId);
            return product != null;
        }
    }
}
