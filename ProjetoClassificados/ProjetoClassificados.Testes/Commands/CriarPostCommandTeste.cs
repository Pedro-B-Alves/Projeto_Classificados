using ProjetoClassificados.Dominio.Commands.Anuncio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjetoClassificados.Testes.Commands
{
    public class CriarPostCommandTeste
    {
        [Fact]
        public void DeveRetornarErroSeDadosForemInvalidos()
        {
            var command = new CriarAnuncioCommand(
                "ps5",
                "ps5 na caixa",
                "",
                1000
            );

            command.Validar();

            Assert.True(command.IsValid, "Os dados estão preenchidos corretamente");
        }

        [Fact]
        public void DeveRetornarErroSeDadosNãoForemPreenchidos()
        {
            var command = new CriarAnuncioCommand();
            command.Nome = "xbox one";
            command.Descricao = "xbox otimo estado";
            command.Imagem = "";
            command.Preco = 1000;

            command.Validar();

            Assert.True(command.IsValid, "Os dados estão preenchidos corretamente");
        }


    }
}
