using FluentValidation;
using RA.PowerSupplySystem.Application.Contracts.Persistence;

namespace RA.PowerSupplySystem.Application.Features.Order.Commands.CreateOrder
{
    public class OrderProductDtoValidator : AbstractValidator<OrderProductDto>
    {
        private readonly IProductRepository _productRepository;

        public OrderProductDtoValidator(IProductRepository productRepository)
        {
            _productRepository = productRepository;

            RuleFor(q => q.ProductId)
                .NotNull().WithMessage("El campo {PropertyName} is obligatorio.")
                .MustAsync(ProductMustExist).WithMessage("El producto con Id '{PropertyValue}' no existe.");

            RuleFor(q => q.Quantity)
                .NotNull().WithMessage("El campo {PropertyName} is obligatorio.")
                .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a {ComparisonValue}.");
        }

        private async Task<bool> ProductMustExist(int productId, CancellationToken token)
        {
            var product = await _productRepository.GetAsync(productId);
            return product != null;
        }
    }
}
