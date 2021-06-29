using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiTech.Data.Migrations
{
    public partial class cambioProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Productos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Productos");
        }
    }
}
