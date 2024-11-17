using ClsApi.Application.Usecases.Commands;
using FluentValidation;

namespace ClsApi.Application.Validators
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .MaximumLength(50).WithMessage("First name must not exceed 50 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .MaximumLength(50).WithMessage("Last name must not exceed 50 characters.");

            RuleFor(x => x.Designation)
                .NotEmpty().WithMessage("Designation is required.")
                .MaximumLength(100).WithMessage("Designation must not exceed 100 characters.");

            RuleFor(x => x.HireDate)
                .NotEmpty().WithMessage("Hire date is required.");

            RuleFor(x => x.Salary)
                .GreaterThan(0).WithMessage("Salary must be greater than 0.");

            RuleFor(x => x.DeptNo)
                .GreaterThan(0).WithMessage("Department number must be greater than 0.");
        }
    }
}