using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyectobis.Migrations
{
    public partial class correxionrel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colocaciones_OfertaTrabajadores_TrabajadorId_OfertaId",
                table: "Colocaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfertaTrabajadores",
                table: "OfertaTrabajadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colocaciones",
                table: "Colocaciones");

            migrationBuilder.DropIndex(
                name: "IX_Colocaciones_TrabajadorId_OfertaId",
                table: "Colocaciones");

            migrationBuilder.DropColumn(
                name: "TrabajadorId",
                table: "Colocaciones");

            migrationBuilder.RenameColumn(
                name: "OfertaId",
                table: "Colocaciones",
                newName: "OfertaTrabajadorId");

            migrationBuilder.AddColumn<int>(
                name: "OfertaTrabajadorId",
                table: "OfertaTrabajadores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "ColocacionId",
                table: "Colocaciones",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfertaTrabajadores",
                table: "OfertaTrabajadores",
                column: "OfertaTrabajadorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colocaciones",
                table: "Colocaciones",
                column: "ColocacionId");

            migrationBuilder.CreateIndex(
                name: "IX_OfertaTrabajadores_OfertaId",
                table: "OfertaTrabajadores",
                column: "OfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_Colocaciones_OfertaTrabajadorId",
                table: "Colocaciones",
                column: "OfertaTrabajadorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Colocaciones_OfertaTrabajadores_OfertaTrabajadorId",
                table: "Colocaciones",
                column: "OfertaTrabajadorId",
                principalTable: "OfertaTrabajadores",
                principalColumn: "OfertaTrabajadorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colocaciones_OfertaTrabajadores_OfertaTrabajadorId",
                table: "Colocaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfertaTrabajadores",
                table: "OfertaTrabajadores");

            migrationBuilder.DropIndex(
                name: "IX_OfertaTrabajadores_OfertaId",
                table: "OfertaTrabajadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colocaciones",
                table: "Colocaciones");

            migrationBuilder.DropIndex(
                name: "IX_Colocaciones_OfertaTrabajadorId",
                table: "Colocaciones");

            migrationBuilder.DropColumn(
                name: "OfertaTrabajadorId",
                table: "OfertaTrabajadores");

            migrationBuilder.RenameColumn(
                name: "OfertaTrabajadorId",
                table: "Colocaciones",
                newName: "OfertaId");

            migrationBuilder.AlterColumn<int>(
                name: "ColocacionId",
                table: "Colocaciones",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "TrabajadorId",
                table: "Colocaciones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfertaTrabajadores",
                table: "OfertaTrabajadores",
                columns: new[] { "OfertaId", "TrabajadorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colocaciones",
                table: "Colocaciones",
                columns: new[] { "ColocacionId", "TrabajadorId", "OfertaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Colocaciones_TrabajadorId_OfertaId",
                table: "Colocaciones",
                columns: new[] { "TrabajadorId", "OfertaId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Colocaciones_OfertaTrabajadores_TrabajadorId_OfertaId",
                table: "Colocaciones",
                columns: new[] { "TrabajadorId", "OfertaId" },
                principalTable: "OfertaTrabajadores",
                principalColumns: new[] { "OfertaId", "TrabajadorId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
