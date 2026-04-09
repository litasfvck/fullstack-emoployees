using backend.DTOs;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController(IEmployeeService employeeService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetAll(CancellationToken ct)
        {
            var employees = await employeeService.GetAllEmployeesAsync(ct);
            return Ok(employees);
        }
    }
}