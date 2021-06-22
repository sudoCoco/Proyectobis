using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyectobis.Migrations
{
    public partial class RelacionOfertaTrabajadorColocacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OfertaTrabajadores",
                table: "OfertaTrabajadores");

            migrationBuilder.AddColumn<int>(
                name: "OfertaId",
                table: "Colocaciones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrabajadorId",
                table: "Colocaciones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_OfertaTrabajadores_OfertaTrabajadorId",
                table: "OfertaTrabajadores",
                column: "OfertaTrabajadorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfertaTrabajadores",
                table: "OfertaTrabajadores",
                columns: new[] { "OfertaId", "TrabajadorId", "OfertaTrabajadorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Colocaciones_OfertaTrabajadorId_TrabajadorId_OfertaId",
                table: "Colocaciones",
                columns: new[] { "OfertaTrabajadorId", "TrabajadorId", "OfertaId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Colocaciones_OfertaTrabajadores_OfertaTrabajadorId_TrabajadorId_OfertaId",
                table: "Colocaciones",
                columns: new[] { "OfertaTrabajadorId", "TrabajadorId", "OfertaId" },
                principalTable: "OfertaTrabajadores",
                principalColumns: new[] { "OfertaId", "TrabajadorId", "OfertaTrabajadorId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colocaciones_OfertaTrabajadores_OfertaTrabajadorId_TrabajadorId_OfertaId",
                table: "Colocaciones");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_OfertaTrabajadores_OfertaTrabajadorId",
                table: "OfertaTrabajadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfertaTrabajadores",
                table: "OfertaTrabajadores");

            migrationBuilder.DropIndex(
                name: "IX_Colocaciones_OfertaTrabajadorId_TrabajadorId_OfertaId",
                table: "Colocaciones");

            migrationBuilder.DropColumn(
                name: "OfertaId",
                table: "Colocaciones");

            migrationBuilder.DropColumn(
                name: "TrabajadorId",
                table: "Colocaciones");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfertaTrabajadores",
                table: "OfertaTrabajadores",
                columns: new[] { "OfertaId", "TrabajadorId" });
        }
    }
}
