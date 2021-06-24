using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiTech.Data.Migrations
{
    public partial class hola : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoEmpleadoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Sueldo = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEmpleadoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleadoes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: true),
                    IdTipoEmpleado = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Celular = table.Column<int>(nullable: false),
                    Correo = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Sueldo = table.Column<decimal>(nullable: false),
                    TipoempleadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleadoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleadoes_TipoEmpleadoes_TipoempleadoId",
                        column: x => x.TipoempleadoId,
                        principalTable: "TipoEmpleadoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleadoes_TipoempleadoId",
                table: "Empleadoes",
                column: "TipoempleadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleadoes");

            migrationBuilder.DropTable(
                name: "TipoEmpleadoes");
        }
    }
}
