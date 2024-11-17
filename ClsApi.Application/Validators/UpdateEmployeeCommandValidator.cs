
using ClsApi.Application.Usecases.Commands.Employees;
using FluentValidation;

namespace ClsApi.Application.Validators
{
    public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        public UpdateEmployeeCommandValidator()
        {
            RuleFor(x => x.EmpNo)
                .GreaterThan(0).WithMessage("Employee number must be greater than 0.");

            RuleFor(x => x.FirstName)
                .MaximumLength(50).WithMessage("First name must not exceed 50 characters.")
                .When(x => !string.IsNullOrEmpty(x.FirstName));

            RuleFor(x => x.LastName)
                .MaximumLength(50).WithMessage("Last name must not exceed 50 characters.")
                .When(x => !string.IsNullOrEmpty(x.LastName));

            RuleFor(x => x.Salary)
                .GreaterThan(0).WithMessage("Salary must be greater than 0.")
                .When(x => x.Salary.HasValue);
        }
    }
}