using Flunt.Notifications;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Comum.Handlers.Contracts;
using ProjetoClassificados.Comum.Utils;
using ProjetoClassificados.Dominio.Commands.Usuario;
using ProjetoClassificados.Dominio.Entidades;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Handlers.Usuarios
{
    public class CriarUsuarioHandler : Notifiable<Notification>, IHandlerCommand<CriarContaCommand>
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public CriarUsuarioHandler(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public ICommandResult Handler(CriarContaCommand command)
        {
            command.Validar();

            if (!command.IsValid)
                return new GenericCommandResult
                (
                    false,
                    "Informe corretamente os dados do usuario",
                    command.Notifications
                );

            var usuarioExiste = _usuarioRepositorio.BuscarPorEmail(command.Email);
            if (usuarioExiste != null)
                return new GenericCommandResult(false, "Email já cadastrado", "Informe outro email");

            command.Senha = Senha.Criptografar(command.Senha);

            Usuario usuario = new Usuario(command.Email, command.Senha, command.Nome, command.Telefone, command.Image, command.Cidade, command.Estado, command.TipoUsuario);

            if (!usuario.IsValid)
                return new GenericCommandResult(false, "Dados de usuário inválidos", usuario.Notifications);

            _usuarioRepositorio.Adicionar(usuario);

            return new GenericCommandResult(true, "Usuario criado", "Token");
        }
    }
}
