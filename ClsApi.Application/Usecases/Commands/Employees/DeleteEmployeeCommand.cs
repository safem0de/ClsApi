using MediatR;

namespace ClsApi.Application.Usecases.Commands.Employees
{
    public class DeleteEmployeeCommand : IRequest<bool>
    {
        public int EmpNo { get; set; }

        public DeleteEmployeeCommand(int empNo)
        {
            EmpNo = empNo;
        }
    }
}