using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyectobis.Migrations
{
    public partial class RelacionOfertaTrabajadorColocacion : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colocaciones",
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

            migrationBuilder.AlterColumn<int>(
                name: "CodigoAgencia",
                table: "Agencias",
                type: "INTEGER",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10)
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

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
                name: "FK_Colocaciones_OfertaTrabajadores_TrabajadorId_OfertaId",
                table: "Colocaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Ofertas_Empresas_EmpresaId",
                table: "Ofertas");

            migrationBuilder.DropForeignKey(
                name: "FK_OfertaTrabajadores_Ofertas_OfertaId",
                table: "OfertaTrabajadores");

            migrationBuilder.DropForeignKey(
                name: "FK_OfertaTrabajadores_Trabajadores_TrabajadorId",
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
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ColocacionId",
                table: "Colocaciones",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoAgencia",
                table: "Agencias",
                type: "int",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 10)
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colocaciones",
                table: "Colocaciones",
                column: "ColocacionId");

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
