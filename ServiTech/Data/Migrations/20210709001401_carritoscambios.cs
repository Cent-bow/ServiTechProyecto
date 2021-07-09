using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiTech.Data.Migrations
{
    public partial class carritoscambios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Carritos_ProductoId",
                table: "Carritos",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Productos_ProductoId",
                table: "Carritos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Productos_ProductoId",
                table: "Carritos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_ProductoId",
                table: "Carritos");
        }
    }
}
