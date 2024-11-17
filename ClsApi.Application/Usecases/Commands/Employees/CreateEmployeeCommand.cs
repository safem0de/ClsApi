using MediatR;

namespace ClsApi.Application.Usecases.Commands
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public int EmpNo { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public DateOnly? HireDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public decimal Salary { get; set; }
        public int DeptNo { get; set; }
    }
}