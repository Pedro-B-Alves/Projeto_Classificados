using Flunt.Notifications;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Comum.Handlers.Contracts;
using ProjetoClassificados.Comum.Utils;
using ProjetoClassificados.Dominio.Commands.Autenticacao;
using ProjetoClassificados.Dominio.Commands.Usuario;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Handlers.Autenticacao
{
    public class LogarHandle : Notifiable<Notification>, IHandlerCommand<LogarCommand>
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LogarHandle(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public ICommandResult Handler(LogarCommand command)
        {
            command.Validar();

            if (!command.IsValid)
                return new GenericCommandResult
                (
                    false,
                    "Dados incorretos",
                    command.Notifications
                );

            var usuario = _usuarioRepositorio.BuscarPorEmail(command.Email);

            if (usuario == null)
                return new GenericCommandResult(false, "Email inválido!", null);

            if (!Senha.Validar(command.Senha, usuario.Senha))
                return new GenericCommandResult(false, "Senha inválida!", null);

            return new GenericCommandResult(true, "Logado com sucesso!", usuario);
        }
    }
}
