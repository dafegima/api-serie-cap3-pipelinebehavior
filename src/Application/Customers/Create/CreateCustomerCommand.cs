using Application.Commons;
using Application.Customers.Commons;
using MediatR;

namespace Application.Customers.Create
{
	public class CreateCustomerCommand : CustomerBase, IRequest<Result<CreateCustomerCommandResponse>>
	{
	}
}