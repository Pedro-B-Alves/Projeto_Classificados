using ProjetoClassificados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjetoClassificados.Testes.Entidades
{
    public class AnuncioTestes
    {
        [Fact]
        public void DeveRetornarSeOAnuncioForValido()
        {
            var anuncio = new Anuncio(
                "ps4",
                "ps4 usado",
                "",
                1000
            );

            Assert.True(anuncio.IsValid, "Anuncio é válido");
        }


    }
}
