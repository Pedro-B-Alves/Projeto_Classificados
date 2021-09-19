using Flunt.Notifications;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Comum.Handlers.Contracts;
using ProjetoClassificados.Dominio.Commands.Anuncio;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Handlers.Anuncios
{
    public class DeletarAnuncioHandler : Notifiable<Notification>, IHandlerCommand<DeletarAnuncioCommand>
    {

        private readonly IAnuncioRepositorio _anuncioRepositorio;

        public DeletarAnuncioHandler(IAnuncioRepositorio anuncioRepositorio)
        {
            _anuncioRepositorio = anuncioRepositorio;
        }

        public ICommandResult Handler(DeletarAnuncioCommand command)
        {
            // Verifica se o command é válido
            command.Validar();

            if (!command.IsValid)
                return new GenericCommandResult(false, "Dados incorretos do anuncio", command.Notifications);

            _anuncioRepositorio.Deletar(command.Id);

            return new GenericCommandResult(true, "Anuncio  deletado", "Token");
        }


    }
}
