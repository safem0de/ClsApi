using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClsApi.Application.Interfaces.Respositories;
using ClsApi.Domain;
using MediatR;

namespace ClsApi.Application.Usecases.Queries.Employees
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, Employee?>
    {
        private readonly IEmployeeRepository _employeeRepository;
        
        public GetEmployeeQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee?> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetByEmpNoAsync(request.EmpNo);
        }

    }
}