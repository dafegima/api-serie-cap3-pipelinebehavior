using Domain.Interfaces.Repositories;
using FluentValidation;

namespace Application.Customers.Commons.Validators
{
	public class IdentificationValidator : AbstractValidator<CustomerBase>
    {
        private readonly ICustomersRepository _customersRepository;
        public IdentificationValidator(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
            RuleFor(x => x.Identification)
                .NotEmpty()
                .MustAsync(IsUniqueIdentification).WithMessage("'{PropertyName}' Customer with identification {PropertyValue} already exist.");
        }

        private async Task<bool> IsUniqueIdentification(string identification, CancellationToken token)
        {
            var customer = await _customersRepository.GetById(identification);
            return customer == null;
        }
    }
}