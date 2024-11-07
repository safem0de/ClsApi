
using ClsApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClsApi.Infrastructure.Data
{
    public class SeedDbContext
    {
        public static async Task SeedData(ApplicationDbContext context)
        {
            if (!await context.Employees.AnyAsync())
            {
                List<Employee> employees = new List<Employee>{
                    new Employee
                    {
                    EmpNo = 1001,
                    FirstName = "John",
                    LastName = "Doe",
                    Designation = ""
                    }
                };


                await context.Employees.AddRangeAsync(employees);
                await context.SaveChangesAsync();
            }
        }
    }
}