using ProjetoClassificados.Comum.Enum;
using ProjetoClassificados.Dominio.Commands.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjetoClassificados.Testes.Commands
{
    public class CriarUsuarioCommandTeste
    {
        [Fact]
        public void DeveRetornarErroSeDadosForemInvalidos()
        {
            var command = new CriarContaCommand(
                "pedro@gmail.com",
                "pedro1234",
                "Pedro",
                11912345678,
                "",
                "São Paulo",
                "São Paulo",
                EnTipoUsuario.Admin
            );

            command.Validar();

            Assert.True(command.IsValid, "Os dados estão preenchidos corretamente");
        }
    }
}
