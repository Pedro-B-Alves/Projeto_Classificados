using Microsoft.EntityFrameworkCore.Migrations;

namespace XPTO.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anuncio",
                columns: table => new
                {
                    idAnuncio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    descricao = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    imagem = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    preco = table.Column<double>(type: "float", nullable: false),
                    idUsuario = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncio", x => x.idAnuncio);
                });

            migrationBuilder.CreateTable(
                name: "Interesse",
                columns: table => new
                {
                    idInteresse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<byte>(type: "tinyint", nullable: false),
                    idAnuncio = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesse", x => x.idInteresse);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuario",
                columns: table => new
                {
                    idTipoUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuario", x => x.idTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    senha = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    nome = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    telefone = table.Column<long>(type: "bigint", maxLength: 11, nullable: false),
                    imagem = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    cidade = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    estado = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    idTipoUsuario = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                });

            migrationBuilder.InsertData(
                table: "Anuncio",
                columns: new[] { "idAnuncio", "descricao", "idUsuario", "imagem", "nome", "preco" },
                values: new object[] { 1, "Em boa condição", (byte)1, "", "playstation 2", 500.0 });

            migrationBuilder.InsertData(
                table: "Interesse",
                columns: new[] { "idInteresse", "idAnuncio", "idUsuario" },
                values: new object[] { 1, (byte)1, (byte)2 });

            migrationBuilder.InsertData(
                table: "TiposUsuario",
                columns: new[] { "idTipoUsuario", "titulo" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Cliente" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "idUsuario", "cidade", "email", "estado", "idTipoUsuario", "imagem", "nome", "senha", "telefone" },
                values: new object[,]
                {
                    { 1, "São Paulo", "admin@admin.com", "São Paulo", (byte)1, "", "admin", "admin1234", 11912345678L },
                    { 2, "São Paulo", "cliente@cliente.com", "São Paulo", (byte)2, "", "cliente", "cliente1234", 11912345678L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_email",
                table: "Usuario",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anuncio");

            migrationBuilder.DropTable(
                name: "Interesse");

            migrationBuilder.DropTable(
                name: "TiposUsuario");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
