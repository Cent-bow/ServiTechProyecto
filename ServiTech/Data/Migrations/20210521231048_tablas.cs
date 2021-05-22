using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiTech.Data.Migrations
{
    public partial class tablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductoCategoria",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "TipoProducto",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "Categoria",
                table: "Productos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaActivo",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Productos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "FechaActivo",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Productos");

            migrationBuilder.AddColumn<string>(
                name: "ProductoCategoria",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoProducto",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
