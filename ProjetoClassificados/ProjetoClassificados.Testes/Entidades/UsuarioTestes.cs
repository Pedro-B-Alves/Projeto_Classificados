using ProjetoClassificados.Comum.Enum;
using ProjetoClassificados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjetoClassificados.Testes.Entidades
{
    public class UsuarioTestes
    {
        [Fact]
        public void DeveRetornarSeUsuarioForValido()
        {
            var usuario = new Usuario(
                "pedro@gmail.com",
                "pedro1234",
                "Pedro",
                11912345678,
                "",
                "São Paulo",
                "São Paulo",
                EnTipoUsuario.Admin
                );

            Assert.True(usuario.IsValid, "Usuário é válido");
        }
    }
}
