using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiTech.Data.Migrations
{
    public partial class o : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Precio",
                table: "Productos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Productos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaActivo",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "Productos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaActivo",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "Productos");

            migrationBuilder.AlterColumn<string>(
                name: "Precio",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
