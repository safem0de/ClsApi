using ClsApi.Application.Usecases.Commands;
using ClsApi.Application.Usecases.Commands.Employees;
using ClsApi.Application.Usecases.Queries.Employees;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClsApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("AllEmployees", Name = "GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _mediator.Send(new GetEmployeesQuery());
            return Ok(employees);
        }

        [HttpGet("GetEmployeeById/{empNo}", Name = "GetEmployeeById")]
        public async Task<IActionResult> GetEmployeeById(int empNo)
        {
            var employee = await _mediator.Send(new GetEmployeeQuery { EmpNo = empNo });
            return Ok(employee);
        }

        [HttpPost("CreateEmployee", Name = "CreateEmployee")]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeCommand request)
        {
            var employee = await _mediator.Send(request);
            return Ok(employee);
        }

        [HttpPut("UpdateEmployee", Name = "UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeCommand request)
        {
            var employee = await _mediator.Send(request);
            return Ok(employee);
        }

        [HttpDelete("DeleteEmployee/{empNo}")]
        public async Task<IActionResult> DeleteEmployee(int empNo)
        {
            var result = await _mediator.Send(new DeleteEmployeeCommand(empNo));

            if (!result)
            {
                return NotFound($"EmpNo:({empNo}) not found");
            }

            return NoContent();
        }
    }
}