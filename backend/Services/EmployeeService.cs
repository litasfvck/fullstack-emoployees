using backend.Data;
using backend.DTOs;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    public class EmployeeService(AppDbContext context) : IEmployeeService
    {
        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync(CancellationToken ct)
        {
            return await context.Employees
                .AsNoTracking()
                .Select(employee => new EmployeeDto(
                    employee.Id,
                    employee.FullName,
                    employee.Position,
                    employee.Department,
                    employee.Salary,
                    employee.HiredAt
                ))
                .ToArrayAsync(ct);
        }
    }
}