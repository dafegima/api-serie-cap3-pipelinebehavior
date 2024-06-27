using FluentValidation;

namespace Application.Customers.Commons.Validators
{
	public class FirstNameValidator : AbstractValidator<CustomerBase>
    {
        public FirstNameValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .Must(firstName => !IsValidName(firstName))
                .WithMessage("FirstName must be a value different from Daniel and Peter.");
        }

        private bool IsValidName(string firstName)
        {
            List<string> forbiddenNames = new List<string>() { "Daniel", "Peter" };
            return forbiddenNames.Contains(firstName);
        }
    }
}

