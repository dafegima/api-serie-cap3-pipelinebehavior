using FluentValidation;

namespace Application.Customers.Commons.Validators
{
	public class LastNameValidator : AbstractValidator<CustomerBase>
    {
        public LastNameValidator()
        {
            RuleFor(x => x.LastName).NotEmpty();
        }
    }
}