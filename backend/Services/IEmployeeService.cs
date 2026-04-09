using backend.DTOs;

namespace backend.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync(CancellationToken ct);
    }
}