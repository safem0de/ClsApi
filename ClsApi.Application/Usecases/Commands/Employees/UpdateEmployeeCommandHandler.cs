using ClsApi.Application.Interfaces.Respositories;
using MediatR;

namespace ClsApi.Application.Usecases.Commands.Employees
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetByEmpNoAsync(request.EmpNo);

            if (employee == null)
            {
                throw new KeyNotFoundException($"Employee with ID {request.EmpNo} not found.");
            }
            else
            {
                employee.FirstName = request.FirstName;
                employee.LastName = request.LastName;
                employee.Designation = request.Designation;
                employee.Salary = request.Salary ?? employee.Salary;
                employee.DeptNo = request.DeptNo;
                employee.Comm = request.Comm;

                await _employeeRepository.UpdateAsync(employee);

                return employee.EmpNo;
            }
        }

    }
}