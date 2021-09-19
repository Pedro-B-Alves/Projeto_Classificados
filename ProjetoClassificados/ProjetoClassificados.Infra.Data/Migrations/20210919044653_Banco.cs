using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoClassificados.Infra.Data.Migrations
{
    public partial class Banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdAnuncio",
                table: "Anuncios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Interesses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    usuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAnuncio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    anuncioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interesses_Anuncios_anuncioId",
                        column: x => x.anuncioId,
                        principalTable: "Anuncios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interesses_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interesses_anuncioId",
                table: "Interesses",
                column: "anuncioId");

            migrationBuilder.CreateIndex(
                name: "IX_Interesses_usuarioId",
                table: "Interesses",
                column: "usuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interesses");

            migrationBuilder.DropColumn(
                name: "IdAnuncio",
                table: "Anuncios");
        }
    }
}
