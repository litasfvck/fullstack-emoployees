using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees => Set<Employee>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            // тестовые данные
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = Guid.Parse("3f3c2c4b-0c8e-4c1a-9b8d-2e4a9f1f7c11"), FullName = "Иван Иванов", Position = "Менеджер", Department = "Продажи", Salary = 50000m, HiredAt = new DateTime(2025, 2, 15, 0, 0, 0, DateTimeKind.Utc) },
                new Employee { Id = Guid.Parse("a1b4d8e2-5f6c-4d9a-8f22-9c3e7b6a1d44"), FullName = "Мария Петрова", Position = "Аналитик", Department = "Маркетинг", Salary = 60000m, HiredAt = new DateTime(2025, 1, 10, 0, 0, 0, DateTimeKind.Utc) },
                new Employee { Id = Guid.Parse("c7e2f9a1-3b4d-4f8e-92aa-1f6b3c9d7e55"), FullName = "Сергей Кузнецов", Position = "Разработчик", Department = "IT", Salary = 75000m, HiredAt = new DateTime(2025, 2, 23, 0, 0, 0, DateTimeKind.Utc) },
                new Employee { Id = Guid.Parse("9d1f4b22-8c3a-4e77-b1d9-5f2a6c4e8f66"), FullName = "Ольга Смирнова", Position = "Бухгалтер", Department = "Финансы", Salary = 55000m, HiredAt = new DateTime(2026, 5, 4, 0, 0, 0, DateTimeKind.Utc) },
                new Employee { Id = Guid.Parse("e4b7a9c3-2d1f-4f6a-8b33-7c9e1a2d3f77"), FullName = "Алексей Морозов", Position = "HR", Department = "Кадры", Salary = 52000m, HiredAt = new DateTime(2026, 7, 25, 0, 0, 0, DateTimeKind.Utc) },
                new Employee { Id = Guid.Parse("f8c1d2e3-4b5a-4c6d-9e88-1a3f7b2c4d88"), FullName = "Екатерина Волкова", Position = "Дизайнер", Department = "Маркетинг", Salary = 58000m, HiredAt = new DateTime(2026, 1, 15, 0, 0, 0, DateTimeKind.Utc) },
                new Employee { Id = Guid.Parse("12a4c6e8-9b3d-4f1e-8c77-5d2e9a1b3c99"), FullName = "Дмитрий Соколов", Position = "Менеджер проектов", Department = "IT", Salary = 80000m, HiredAt = new DateTime(2025, 10, 25, 0, 0, 0, DateTimeKind.Utc) },
                new Employee { Id = Guid.Parse("7b9e2d1c-3f4a-4c8e-91aa-6e5c3d2b1a10"), FullName = "Анастасия Фёдорова", Position = "Секретарь", Department = "Администрация", Salary = 40000m, HiredAt = new DateTime(2025, 1, 13, 0, 0, 0, DateTimeKind.Utc) },
                new Employee { Id = Guid.Parse("d4c3b2a1-8e7f-4a6c-9d55-2b1c4e3f5a21"), FullName = "Николай Орлов", Position = "Тестировщик", Department = "IT", Salary = 60000m, HiredAt = new DateTime(2025, 11, 2, 0, 0, 0, DateTimeKind.Utc) },
                new Employee { Id = Guid.Parse("8e1f2c3d-4b5a-4d6e-8f99-7c2a1b3e4d32"), FullName = "Татьяна Крылова", Position = "Маркетолог", Department = "Маркетинг", Salary = 57000m, HiredAt = new DateTime(2026, 6, 1, 0, 0, 0, DateTimeKind.Utc) }
            );
        }
    }
}