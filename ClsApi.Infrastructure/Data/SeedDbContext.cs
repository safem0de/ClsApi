
using ClsApi.Domain;

namespace ClsApi.Infrastructure.Data
{
    public class SeedDbContext
    {
        public static async Task SeedData(ApplicationDbContext context)
        {
            if (!context.Employees.Any())
            {
                List<Employee> employees = new List<Employee>();

                employees.Add(new Employee()
                {
                    EmpNo = 1001,
                    FirstName = "John", 
                    LastName = "Doe",
                });

                await context.Employees.AddRangeAsync(employees);
                await context.SaveChangesAsync();
            }
        }
    }
}