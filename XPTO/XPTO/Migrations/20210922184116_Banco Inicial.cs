using Microsoft.EntityFrameworkCore.Migrations;

namespace XPTO.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    idTipoUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.idTipoUsuario);
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
                    idTipoUsuario = table.Column<byte>(type: "tinyint", nullable: false),
                    idTipoUsuarioNavigationidTipoUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_TipoUsuario_idTipoUsuarioNavigationidTipoUsuario",
                        column: x => x.idTipoUsuarioNavigationidTipoUsuario,
                        principalTable: "TipoUsuario",
                        principalColumn: "idTipoUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    idUsuario = table.Column<byte>(type: "tinyint", nullable: false),
                    idUsuarioNavigationidUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncio", x => x.idAnuncio);
                    table.ForeignKey(
                        name: "FK_Anuncio_Usuario_idUsuarioNavigationidUsuario",
                        column: x => x.idUsuarioNavigationidUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interesse",
                columns: table => new
                {
                    idInteresse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<byte>(type: "tinyint", nullable: false),
                    idAnuncio = table.Column<byte>(type: "tinyint", nullable: false),
                    idUsuarioNavigationidUsuario = table.Column<int>(type: "int", nullable: true),
                    idAnuncioNavigationidAnuncio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesse", x => x.idInteresse);
                    table.ForeignKey(
                        name: "FK_Interesse_Anuncio_idAnuncioNavigationidAnuncio",
                        column: x => x.idAnuncioNavigationidAnuncio,
                        principalTable: "Anuncio",
                        principalColumn: "idAnuncio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Interesse_Usuario_idUsuarioNavigationidUsuario",
                        column: x => x.idUsuarioNavigationidUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Anuncio",
                columns: new[] { "idAnuncio", "descricao", "idUsuario", "idUsuarioNavigationidUsuario", "imagem", "nome", "preco" },
                values: new object[] { 1, "Em boa condição", (byte)1, null, "", "playstation 2", 500.0 });

            migrationBuilder.InsertData(
                table: "Interesse",
                columns: new[] { "idInteresse", "idAnuncio", "idAnuncioNavigationidAnuncio", "idUsuario", "idUsuarioNavigationidUsuario" },
                values: new object[] { 1, (byte)1, null, (byte)2, null });

            migrationBuilder.InsertData(
                table: "TipoUsuario",
                columns: new[] { "idTipoUsuario", "titulo" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Cliente" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "idUsuario", "cidade", "email", "estado", "idTipoUsuario", "idTipoUsuarioNavigationidTipoUsuario", "imagem", "nome", "senha", "telefone" },
                values: new object[,]
                {
                    { 1, "São Paulo", "admin@admin.com", "São Paulo", (byte)1, null, "", "admin", "admin1234", 11912345678L },
                    { 2, "São Paulo", "cliente@cliente.com", "São Paulo", (byte)2, null, "", "cliente", "cliente1234", 11912345678L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anuncio_idUsuarioNavigationidUsuario",
                table: "Anuncio",
                column: "idUsuarioNavigationidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Interesse_idAnuncioNavigationidAnuncio",
                table: "Interesse",
                column: "idAnuncioNavigationidAnuncio");

            migrationBuilder.CreateIndex(
                name: "IX_Interesse_idUsuarioNavigationidUsuario",
                table: "Interesse",
                column: "idUsuarioNavigationidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_email",
                table: "Usuario",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_idTipoUsuarioNavigationidTipoUsuario",
                table: "Usuario",
                column: "idTipoUsuarioNavigationidTipoUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interesse");

            migrationBuilder.DropTable(
                name: "Anuncio");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "TipoUsuario");
        }
    }
}
