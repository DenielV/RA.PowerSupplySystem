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
                .NotNull().WithMessage("El campo {PropertyName} is obligatorio.")
                .Must(ProductsListMustNotBeEmpty).WithMessage("Se debe agregar por lo menos un producto a la orden.");

            RuleForEach(q => q.Products).SetValidator(new OrderProductDtoValidator(_productRepository));
        }

        private bool ProductsListMustNotBeEmpty(List<OrderProductDto> products)
        {
            return products.Count > 0;
        }
    }
}
