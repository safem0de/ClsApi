using ClsApi.Application.Interfaces.Respositories;
using MediatR;

namespace ClsApi.Application.Usecases.Commands.Employees
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var employee = await _employeeRepository.GetByEmpNoAsync(request.EmpNo);
                
                if (employee == null)
                {
                    return false; // Employee not found
                }

                await _employeeRepository.DeleteAsync(employee);
                return true; // Deletion successful
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw; // Re-throw the exception to handle it in the calling code
            }
        }
    }
}