using Flunt.Notifications;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Comum.Handlers.Contracts;
using ProjetoClassificados.Dominio.Commands.Anuncio;
using ProjetoClassificados.Dominio.Entidades;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Handlers.Anuncios
{
    public class CriarAnuncioHandler : Notifiable<Notification>, IHandler<CriarAnuncioCommand>
    {

        private readonly IAnuncioRepositorio _anuncioRepositorio;

        public CriarAnuncioHandler(IAnuncioRepositorio anuncioRepositorio)
        {
            _anuncioRepositorio = anuncioRepositorio;
        }

        public ICommandResult Handler(CriarAnuncioCommand command)
        {
            //Verifica se o command é válido
            command.Validar();

            if (!command.IsValid)
                return new GenericCommandResult
                (
                    false,
                    "Informe corretamente os campos do anuncio",
                    command.Notifications
                );

            //Salvar no banco 
            Anuncio anuncio = new Anuncio(command.Nome, command.Descricao, command.Imagem, command.Preco);

            if (!anuncio.IsValid)
                return new GenericCommandResult(false, "Os dados do anuncio são inválidos", anuncio.Notifications);

            _anuncioRepositorio.Cadastrar(anuncio);


            //Podemos salvar no banco - repositorio.Adicionar(anuncio)
            return new GenericCommandResult(true, "Anuncio criado", "Token");
        }

    }
}
