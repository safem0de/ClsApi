using MediatR;

namespace ClsApi.Application.Usecases.Commands.Employees
{
    public class UpdateEmployeeCommand : IRequest<int>
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