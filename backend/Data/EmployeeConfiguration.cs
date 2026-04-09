using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Data
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("employees").HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.FullName).HasColumnName("full_name").IsRequired();
            builder.Property(e => e.Position).HasColumnName("position").IsRequired();
            builder.Property(e => e.Department).HasColumnName("department");
            builder.Property(e => e.Salary).HasColumnName("salary").HasColumnType("numeric(18,2)");
            builder.Property(e => e.HiredAt).HasColumnName("hired_at");
        }
    }
}