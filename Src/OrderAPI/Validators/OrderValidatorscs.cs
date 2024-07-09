using FluentValidation;
using OrderAPI.Models;

namespace OrderAPI.Validators
{
    public class OrderValidatorscs: AbstractValidator<Order>
    {
        public OrderValidatorscs()
        {
            RuleFor(o => o.LastName).NotEmpty().MaximumLength(20);
            RuleFor(o => o.Description).NotEmpty().MaximumLength(100);
            RuleFor(o => o.Quantity).InclusiveBetween(1, 20);
            RuleFor(o => o.FirstName).MaximumLength(20).When(o => !string.IsNullOrEmpty(o.FirstName));
        }
    }
}
