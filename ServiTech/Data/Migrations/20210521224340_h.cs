using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiTech.Data.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductoCategoria",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoProducto",
                table: "Productos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ProductoCategoria",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "TipoProducto",
                table: "Productos");
        }
    }
}
