using ClsApi.Domain;
using MediatR;

namespace ClsApi.Application.Usecases.Queries.Employees
{
    public class GetEmployeesQuery : IRequest<IEnumerable<Employee>>
    {
        public int EmpNo { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public DateOnly HireDate { get; set; }
        public decimal Salary { get; set; }
        public decimal? Comm { get; set; }
        public int DeptNo { get; set; }
    }
}