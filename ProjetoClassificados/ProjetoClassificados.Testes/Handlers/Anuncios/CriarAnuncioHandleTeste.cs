using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Dominio.Commands.Anuncio;
using ProjetoClassificados.Dominio.Handlers.Anuncios;
using ProjetoClassificados.Testes.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjetoClassificados.Testes.Handlers.Anuncios
{
    public class CriarAnuncioHandleTeste
    {
        [Fact]
        public void DevemRetornarCasoOsDadosDoHandleSejamValidos()
        {
            //Criar command
            var command = new CriarAnuncioCommand();
            command.Nome        = "ps5";
            command.Descricao   = "ps5 na caixa";
            command.Imagem      = "";
            command.Preco       = 1000;

            //Criar handle
            var handle = new CriarAnuncioHandler( new FakeAnuncioRepositorio() );

            //Pegar o Resultado
            //Como Handler de IHandler retorna um ICommandResult, convertemos ele para GenericCommandResult
            var resultado = (GenericCommandResult)handle.Handler(command);

            //Validar a condição
            Assert.True(resultado.Sucesso, "Usuário válido");

        }

    }
}
