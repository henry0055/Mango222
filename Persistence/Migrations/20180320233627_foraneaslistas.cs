using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Persistence.Migrations
{
    public partial class foraneaslistas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categorias_medias_mediaId",
                table: "categorias");

            migrationBuilder.DropIndex(
                name: "IX_categorias_mediaId",
                table: "categorias");

            migrationBuilder.DropColumn(
                name: "IdMedia",
                table: "categorias");

            migrationBuilder.DropColumn(
                name: "mediaId",
                table: "categorias");

            migrationBuilder.CreateTable(
                name: "actores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Imagen = table.Column<string>(nullable: true),
                    Nacionalidad = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "comentario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdMedia = table.Column<int>(nullable: false),
                    IdPersona = table.Column<int>(nullable: false),
                    contenido = table.Column<string>(nullable: true),
                    fecha = table.Column<DateTime>(nullable: false),
                    mediaId = table.Column<int>(nullable: true),
                    personaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comentario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_comentario_medias_mediaId",
                        column: x => x.mediaId,
                        principalTable: "medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_comentario_personas_personaId",
                        column: x => x.personaId,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mediaxcategoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCategoria = table.Column<int>(nullable: false),
                    IdMedia = table.Column<int>(nullable: false),
                    categoriaId = table.Column<int>(nullable: true),
                    mediaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mediaxcategoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mediaxcategoria_categorias_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mediaxcategoria_medias_mediaId",
                        column: x => x.mediaId,
                        principalTable: "medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mediaxactor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdActor = table.Column<int>(nullable: false),
                    IdMedia = table.Column<int>(nullable: false),
                    actorId = table.Column<int>(nullable: true),
                    mediaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mediaxactor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mediaxactor_actores_actorId",
                        column: x => x.actorId,
                        principalTable: "actores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mediaxactor_medias_mediaId",
                        column: x => x.mediaId,
                        principalTable: "medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comentario_mediaId",
                table: "comentario",
                column: "mediaId");

            migrationBuilder.CreateIndex(
                name: "IX_comentario_personaId",
                table: "comentario",
                column: "personaId");

            migrationBuilder.CreateIndex(
                name: "IX_mediaxactor_actorId",
                table: "mediaxactor",
                column: "actorId");

            migrationBuilder.CreateIndex(
                name: "IX_mediaxactor_mediaId",
                table: "mediaxactor",
                column: "mediaId");

            migrationBuilder.CreateIndex(
                name: "IX_mediaxcategoria_categoriaId",
                table: "mediaxcategoria",
                column: "categoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_mediaxcategoria_mediaId",
                table: "mediaxcategoria",
                column: "mediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comentario");

            migrationBuilder.DropTable(
                name: "mediaxactor");

            migrationBuilder.DropTable(
                name: "mediaxcategoria");

            migrationBuilder.DropTable(
                name: "actores");

            migrationBuilder.AddColumn<int>(
                name: "IdMedia",
                table: "categorias",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mediaId",
                table: "categorias",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_categorias_mediaId",
                table: "categorias",
                column: "mediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_categorias_medias_mediaId",
                table: "categorias",
                column: "mediaId",
                principalTable: "medias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
