
using ClsApi.Application.Interfaces.Respositories;
using ClsApi.Domain;

using MediatR;

namespace ClsApi.Application.Usecases.Commands
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Designation = request.Designation,
                HireDate = request.HireDate,
                Salary = request.Salary,
                DeptNo = request.DeptNo,
            };

            try
            {
                await _employeeRepository.AddAsync(employee);
                return employee.EmpNo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }

}