using FluentValidation;

namespace Application.Customers.Commons.Validators
{
	public class CountryValidator : AbstractValidator<CustomerBase>
    {
        public CountryValidator()
        {
            When(x => !string.IsNullOrEmpty(x.Address),
                () => RuleFor(x => x.City).NotEmpty())
                .Otherwise(() => RuleFor(x => x.City).Empty());
        }
    }
}