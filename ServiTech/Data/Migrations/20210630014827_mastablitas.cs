using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiTech.Data.Migrations
{
    public partial class mastablitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DireccionesEnvios",
                columns: table => new
                {
                    IdDireccion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDestinatario = table.Column<string>(nullable: true),
                    NumeroTelefono = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionesEnvios", x => x.IdDireccion);
                });

            migrationBuilder.CreateTable(
                name: "PagoConTarjeta",
                columns: table => new
                {
                    IdTarjeta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarjetasAceptadas = table.Column<string>(nullable: true),
                    NombreTitular = table.Column<string>(nullable: true),
                    NumeroTarjeta = table.Column<string>(nullable: true),
                    FechaExpiracion = table.Column<DateTime>(nullable: true),
                    CodigoSeguridad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagoConTarjeta", x => x.IdTarjeta);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DireccionesEnvios");

            migrationBuilder.DropTable(
                name: "PagoConTarjeta");
        }
    }
}
