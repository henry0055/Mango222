using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Persistence.Migrations
{
    public partial class agregandoSipnosisYCalificar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Acumulado",
                table: "medias",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Contador",
                table: "medias",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sinopsis",
                table: "medias",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acumulado",
                table: "medias");

            migrationBuilder.DropColumn(
                name: "Contador",
                table: "medias");

            migrationBuilder.DropColumn(
                name: "Sinopsis",
                table: "medias");
        }
    }
}
