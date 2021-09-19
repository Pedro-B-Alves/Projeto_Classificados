using Flunt.Notifications;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Comum.Handlers.Contracts;
using ProjetoClassificados.Dominio.Commands.Interesse;
using ProjetoClassificados.Dominio.Entidades;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Handlers
{
    public class AdicionarInteresseHandle : Notifiable<Notification>, IHandlerCommand<AdicionarInteresseCommand>
    {

        private readonly IInteresseRepositorio _interesseRepositorio;

        public AdicionarInteresseHandle(IInteresseRepositorio interesseRepositorio)
        {
            _interesseRepositorio = interesseRepositorio;
        }

        public ICommandResult Handler(AdicionarInteresseCommand command)
        {
            command.Validar();

            if (!command.IsValid)
                return new GenericCommandResult(false, "Dados incorretos do pacote", command.Notifications);

            Interesse interesse = new Interesse(
               
               command.IdUsuario,
               command.IdAnuncio
           );

            _interesseRepositorio.Adicionar(interesse);

            return new GenericCommandResult(true, "Cadastrado com sucesso!", interesse);

        }
    }
}
