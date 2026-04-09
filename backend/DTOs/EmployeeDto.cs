namespace backend.DTOs
{
    public record EmployeeDto(
        Guid Id,
        string FullName,
        string Position,
        string Department,
        decimal Salary,
        DateTime HiredAt);
}