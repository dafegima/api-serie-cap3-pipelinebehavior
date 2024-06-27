using FluentValidation;

namespace Application.Customers.Commons.Validators
{
	public class EmailValidator : AbstractValidator<CustomerBase>
    {
        public EmailValidator()
        {
            RuleFor(x => x.Email).NotEmpty().Matches(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
        }
    }
}