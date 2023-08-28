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
                .NotNull().WithMessage("{PropertyName} is required")
                .MustAsync(ProductMustExist).WithMessage("Product with Id '{PropertyValue}' does not exist");

            RuleFor(q => q.Quantity)
                .NotNull().WithMessage("{PropertyName} is required")
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than {ComparisonValue}");
        }

        private async Task<bool> ProductMustExist(int productId, CancellationToken token)
        {
            var product = await _productRepository.GetAsync(productId);
            return product != null;
        }
    }
}
