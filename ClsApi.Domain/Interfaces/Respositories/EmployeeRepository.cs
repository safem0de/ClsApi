using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClsApi.Domain.Interfaces.Respositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task AddAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}