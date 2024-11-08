using ClsApi.Application.Interfaces.Respositories;
using ClsApi.Domain;
using ClsApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ClsApi.Infrastructure.Interfaces.Respositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Employee employee)
        {
            var existingEmployee = await _context.Employees.FindAsync(employee.EmpNo);
            if (existingEmployee != null)
            {
                _context.Employees.Remove(existingEmployee);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }


        public async Task<Employee?> GetByEmpNoAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task UpdateAsync(Employee employee)
        {
            var existingEmployee = await _context.Employees.FindAsync(employee.EmpNo);
            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Designation = employee.Designation;
                existingEmployee.Salary = employee.Salary;
                existingEmployee.DeptNo = employee.DeptNo;
                existingEmployee.HireDate = employee.HireDate;

                await _context.SaveChangesAsync();
            }
        }
    }
}