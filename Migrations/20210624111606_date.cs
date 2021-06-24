using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyectobis.Migrations
{
    public partial class date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Trabajadores",
                type: "DATE",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOfertaEnviada",
                table: "OfertaTrabajadores",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaColocacion",
                table: "Colocaciones",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Trabajadores",
                type: "date",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaOfertaEnviada",
                table: "OfertaTrabajadores",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaColocacion",
                table: "Colocaciones",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");
        }
    }
}
