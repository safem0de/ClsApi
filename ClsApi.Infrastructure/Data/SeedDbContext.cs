
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
                        FirstName = "Stefan",
                        LastName = "Salvatore",
                        Designation = "Business Analyst",
                        HireDate = new DateOnly(1997, 11, 17),
                        Salary = 50000,
                        DeptNo = 40
                    },
                    new Employee
                    {
                        EmpNo = 1002,
                        FirstName = "Diana",
                        LastName = "Lorrence",
                        Designation = "Technical Architect",
                        HireDate = new DateOnly(2000, 5, 1),
                        Salary = 70000,
                        DeptNo = 10
                    },
                    new Employee
                    {
                        EmpNo = 1003,
                        FirstName = "James",
                        LastName = "Madinsaon",
                        Designation = "Manager",
                        HireDate = new DateOnly(1988, 6, 19),
                        Salary = 80400,
                        DeptNo = 40
                    },
                    new Employee
                    {
                        EmpNo = 1005,
                        FirstName = "Lucy",
                        LastName = "Gelller",
                        Designation = "HR Associate",
                        HireDate = new DateOnly(2008, 6, 13),
                        Salary = 35000,
                        Comm = 200,
                        DeptNo = 30
                    },
                    new Employee
                    {
                        EmpNo = 1006,
                        FirstName = "Issac",
                        LastName = "Stefan",
                        Designation = "Trainee",
                        HireDate = new DateOnly(2015, 12, 13),
                        Salary = 20000,
                        DeptNo = 40
                    },
                    new Employee
                    {
                        EmpNo = 1007,
                        FirstName = "John",
                        LastName = "Smith",
                        Designation = "Clerk",
                        HireDate = new DateOnly(2005, 12, 17),
                        Salary = 12000,
                        DeptNo = 10
                    },
                    new Employee
                    {
                        EmpNo = 1008,
                        FirstName = "Nancy",
                        LastName = "Gillbert",
                        Designation = "Salesman",
                        HireDate = new DateOnly(1981, 2, 20),
                        Salary = 1600,
                        Comm = 300,
                        DeptNo = 10
                    },
                    new Employee
                    {
                        EmpNo = 1004,
                        FirstName = "Jones",
                        LastName = "Nick",
                        Designation = "HR Analyst",
                        HireDate = new DateOnly(2003, 1, 2),
                        Salary = 47000,
                        DeptNo = 30
                    }
                };


                await context.Employees.AddRangeAsync(employees);
                await context.SaveChangesAsync();
            }
        }
    }
}