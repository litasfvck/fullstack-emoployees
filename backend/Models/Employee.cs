namespace backend.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime HiredAt { get; set; }
    }
}