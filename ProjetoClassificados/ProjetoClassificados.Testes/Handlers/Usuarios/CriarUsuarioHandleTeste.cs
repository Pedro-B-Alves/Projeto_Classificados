using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Comum.Enum;
using ProjetoClassificados.Dominio.Commands.Usuario;
using ProjetoClassificados.Dominio.Handlers.Usuarios;
using ProjetoClassificados.Testes.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjetoClassificados.Testes.Handlers.Usuarios
{
    public class CriarUsuarioHandleTeste
    {
        [Fact]
        public void DevemRetornarCasoOsDadosDoHandleSejamValidos()
        {
            var command = new CriarContaCommand();
            command.Email = "pedro@gmail.com";
            command.Senha = "pedro1234";
            command.Nome = "Pedro";
            command.Telefone = 11912345678;
            command.Image = "";
            command.Cidade = "São Paulo";
            command.Estado = "São Paulo";
            command.TipoUsuario = EnTipoUsuario.Admin;

            var handle = new CriarUsuarioHandler(new FakeUsuarioRepositorio());

            var resultado = (GenericCommandResult)handle.Handler(command);

            Assert.True(resultado.Sucesso, "Usuário válido");
        }
    }
}
