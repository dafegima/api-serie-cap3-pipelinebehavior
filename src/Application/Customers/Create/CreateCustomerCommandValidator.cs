using Application.Customers.Commons.Validators;
using Domain.Interfaces.Repositories;
using FluentValidation;

namespace Application.Customers.Create
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator(ICustomersRepository customersRepository)
        {
            Include(new IdentificationValidator(customersRepository));
            Include(new FirstNameValidator());
            Include(new LastNameValidator());
            Include(new EmailValidator());
            Include(new CityValidator());
            Include(new CountryValidator());
        }
    }
}