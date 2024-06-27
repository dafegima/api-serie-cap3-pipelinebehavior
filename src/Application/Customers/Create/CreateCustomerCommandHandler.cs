using Application.Commons;
using Domain.Entities;
using Domain.Interfaces.UseCases;
using MediatR;

namespace Application.Customers.Create
{
	public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Result<CreateCustomerCommandResponse>>
	{
        private readonly ICreateCustomerUseCase _createCustomerUseCase;

        public CreateCustomerCommandHandler(ICreateCustomerUseCase createCustomerUseCase)
        {
            _createCustomerUseCase = createCustomerUseCase;
        }

        public async Task<Result<CreateCustomerCommandResponse>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.Identification, request.FirstName, request.LastName, request.Email, request.BirthDate, request.Address, request.City, request.Country);
            var result = await _createCustomerUseCase.Execute(customer);
            return Result<CreateCustomerCommandResponse>.Success(MapToResponse(result));
        }

        private CreateCustomerCommandResponse MapToResponse(Customer customer)
        {
            return new CreateCustomerCommandResponse(customer.Identification, customer.FirstName, customer.LastName, customer.Email, customer.BirthDate, customer.Address, customer.City, customer.Country);
        }
    }
}