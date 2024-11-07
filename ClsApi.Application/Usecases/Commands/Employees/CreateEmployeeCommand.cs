using MediatR;

namespace ClsApi.Application.Usecases.Commands
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Designation { get; set; }
        public decimal Salary { get; set; }
    }
}