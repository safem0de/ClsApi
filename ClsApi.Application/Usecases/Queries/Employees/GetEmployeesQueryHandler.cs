using ClsApi.Application.Interfaces.Respositories;
using ClsApi.Domain;
using MediatR;

namespace ClsApi.Application.Usecases.Queries.Employees
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, IEnumerable<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeesQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Task<IEnumerable<Employee>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            return _employeeRepository.GetAllAsync();
        }
    }


}