using FluentValidation;

namespace Application.Customers.Commons.Validators
{
	public class CityValidator : AbstractValidator<CustomerBase>
    {
        public CityValidator()
        {
            When(x => !string.IsNullOrEmpty(x.Address),
                () => RuleFor(x => x.Country).NotEmpty())
                .Otherwise(() => RuleFor(x => x.Country).Empty());
        }
    }
}