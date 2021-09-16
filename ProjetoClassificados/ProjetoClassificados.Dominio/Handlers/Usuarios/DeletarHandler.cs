using Flunt.Notifications;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Comum.Handlers.Contracts;
using ProjetoClassificados.Dominio.Commands.Usuario;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Handlers.Usuarios
{
    public class DeletarHandler : Notifiable<Notification>, IHandlerCommand<DeletarCommand>
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public DeletarHandler(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public ICommandResult Handler(DeletarCommand command)
        {
            command.Validar();

            if (!command.IsValid)
                return new GenericCommandResult
                (
                    false,
                    "Informe corretamente o id do usuário",
                    command.Notifications
                );

            _usuarioRepositorio.Excluir((Guid)command.Id);

            return new GenericCommandResult(true, "Usuario excluido", "Token");
        }
    }
}
