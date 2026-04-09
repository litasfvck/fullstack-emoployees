using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    position = table.Column<string>(type: "text", nullable: false),
                    department = table.Column<string>(type: "text", nullable: false),
                    salary = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    hired_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "department", "full_name", "hired_at", "position", "salary" },
                values: new object[,]
                {
                    { new Guid("12a4c6e8-9b3d-4f1e-8c77-5d2e9a1b3c99"), "IT", "Дмитрий Соколов", new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Менеджер проектов", 80000m },
                    { new Guid("3f3c2c4b-0c8e-4c1a-9b8d-2e4a9f1f7c11"), "Продажи", "Иван Иванов", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Менеджер", 50000m },
                    { new Guid("7b9e2d1c-3f4a-4c8e-91aa-6e5c3d2b1a10"), "Администрация", "Анастасия Фёдорова", new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Секретарь", 40000m },
                    { new Guid("8e1f2c3d-4b5a-4d6e-8f99-7c2a1b3e4d32"), "Маркетинг", "Татьяна Крылова", new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Маркетолог", 57000m },
                    { new Guid("9d1f4b22-8c3a-4e77-b1d9-5f2a6c4e8f66"), "Финансы", "Ольга Смирнова", new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Бухгалтер", 55000m },
                    { new Guid("a1b4d8e2-5f6c-4d9a-8f22-9c3e7b6a1d44"), "Маркетинг", "Мария Петрова", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Аналитик", 60000m },
                    { new Guid("c7e2f9a1-3b4d-4f8e-92aa-1f6b3c9d7e55"), "IT", "Сергей Кузнецов", new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Разработчик", 75000m },
                    { new Guid("d4c3b2a1-8e7f-4a6c-9d55-2b1c4e3f5a21"), "IT", "Николай Орлов", new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Тестировщик", 60000m },
                    { new Guid("e4b7a9c3-2d1f-4f6a-8b33-7c9e1a2d3f77"), "Кадры", "Алексей Морозов", new DateTime(2026, 7, 25, 0, 0, 0, 0, DateTimeKind.Utc), "HR", 52000m },
                    { new Guid("f8c1d2e3-4b5a-4c6d-9e88-1a3f7b2c4d88"), "Маркетинг", "Екатерина Волкова", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Дизайнер", 58000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
