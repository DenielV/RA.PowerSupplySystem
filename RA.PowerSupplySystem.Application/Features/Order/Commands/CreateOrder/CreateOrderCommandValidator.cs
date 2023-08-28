using FluentValidation;
using RA.PowerSupplySystem.Application.Contracts.Persistence;

namespace RA.PowerSupplySystem.Application.Features.Order.Commands.CreateOrder
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        private readonly IProductRepository _productRepository;

        public CreateOrderCommandValidator(IProductRepository productRepository)
        {
            _productRepository = productRepository;

            RuleFor(q => q.Products)
                .NotNull().WithMessage("{PropertyName} is required")
                .Must(ProductsListMustNotBeEmpty).WithMessage("You have to add at least one product to the order");

            RuleForEach(q => q.Products).SetValidator(new OrderProductDtoValidator(_productRepository));
        }

        private bool ProductsListMustNotBeEmpty(List<OrderProductDto> products)
        {
            return products.Count > 0;
        }
    }
}
