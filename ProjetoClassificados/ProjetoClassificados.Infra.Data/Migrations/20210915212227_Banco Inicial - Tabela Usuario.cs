using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoClassificados.Infra.Data.Migrations
{
    public partial class BancoInicialTabelaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    Senha = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    Nome = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    Telefone = table.Column<long>(type: "bigint", maxLength: 11, nullable: false),
                    Image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
