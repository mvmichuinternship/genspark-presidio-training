using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace doctorWebApp.Migrations
{
    public partial class doctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Experience", "Name", "Salary", "Specialization" },
                values: new object[] { 101, 2, "mv", 1000, "Cardio" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Experience", "Name", "Salary", "Specialization" },
                values: new object[] { 102, 2, "vk", 1500, "Neuro" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Experience", "Name", "Salary", "Specialization" },
                values: new object[] { 103, 2, "mk", 1500, "Gastro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
