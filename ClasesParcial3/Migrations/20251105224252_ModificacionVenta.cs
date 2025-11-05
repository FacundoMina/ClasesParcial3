using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesParcial3.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionVenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VentaId",
                table: "Venta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venta_VentaId",
                table: "Venta",
                column: "VentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Venta_VentaId",
                table: "Venta",
                column: "VentaId",
                principalTable: "Venta",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Venta_VentaId",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_VentaId",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "VentaId",
                table: "Venta");
        }
    }
}
