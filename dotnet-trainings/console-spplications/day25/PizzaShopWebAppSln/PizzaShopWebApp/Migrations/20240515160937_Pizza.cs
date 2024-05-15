using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaShopWebApp.Migrations
{
    public partial class Pizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Availability", "PizzaName", "Price", "QuantityInStock" },
                values: new object[] { 101, "Available", "Margarita", 99, 25 });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Availability", "PizzaName", "Price", "QuantityInStock" },
                values: new object[] { 102, "Not Available", "Peppy Paneer", 299, 0 });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Availability", "PizzaName", "Price", "QuantityInStock" },
                values: new object[] { 103, "Available", "Farmhouse", 299, 20 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
