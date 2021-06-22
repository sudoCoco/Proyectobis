using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyectobis.Migrations
{
    public partial class OnDeleteMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ofertas_Empresas_EmpresaId",
                table: "Ofertas");

            migrationBuilder.DropForeignKey(
                name: "FK_OfertaTrabajadores_Ofertas_OfertaId",
                table: "OfertaTrabajadores");

            migrationBuilder.DropForeignKey(
                name: "FK_OfertaTrabajadores_Trabajadores_TrabajadorId",
                table: "OfertaTrabajadores");

            migrationBuilder.AddForeignKey(
                name: "FK_Ofertas_Empresas_EmpresaId",
                table: "Ofertas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "EmpresaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_OfertaTrabajadores_Ofertas_OfertaId",
                table: "OfertaTrabajadores",
                column: "OfertaId",
                principalTable: "Ofertas",
                principalColumn: "OfertaId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_OfertaTrabajadores_Trabajadores_TrabajadorId",
                table: "OfertaTrabajadores",
                column: "TrabajadorId",
                principalTable: "Trabajadores",
                principalColumn: "TrabajadorId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ofertas_Empresas_EmpresaId",
                table: "Ofertas");

            migrationBuilder.DropForeignKey(
                name: "FK_OfertaTrabajadores_Ofertas_OfertaId",
                table: "OfertaTrabajadores");

            migrationBuilder.DropForeignKey(
                name: "FK_OfertaTrabajadores_Trabajadores_TrabajadorId",
                table: "OfertaTrabajadores");

            migrationBuilder.AddForeignKey(
                name: "FK_Ofertas_Empresas_EmpresaId",
                table: "Ofertas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "EmpresaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OfertaTrabajadores_Ofertas_OfertaId",
                table: "OfertaTrabajadores",
                column: "OfertaId",
                principalTable: "Ofertas",
                principalColumn: "OfertaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OfertaTrabajadores_Trabajadores_TrabajadorId",
                table: "OfertaTrabajadores",
                column: "TrabajadorId",
                principalTable: "Trabajadores",
                principalColumn: "TrabajadorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
