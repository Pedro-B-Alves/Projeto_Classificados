using ProjetoClassificados.Comum.Handlers.Contracts;
using ProjetoClassificados.Comum.Queries;
using ProjetoClassificados.Dominio.Commands.Usuario;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoClassificados.Dominio.Commands.Usuario.BuscarPorIdUsuarioQuery;

namespace ProjetoClassificados.Dominio.Handlers.Usuarios
{
    public class BuscarPorIdUsuarioHandler : IHandlerQuery<BuscarPorIdUsuarioQuery>
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public BuscarPorIdUsuarioHandler(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IQueryResult Handler(BuscarPorIdUsuarioQuery query)
        {
            var usuario = _usuarioRepositorio.BuscarPorId(query.Id);

            if (usuario == null)
                return new GenericQueryResult(false, "Usuário não encontrado", null);

            /*var retornoUsuario = usuario.Select(
                x =>
               {
                    return new ProcurarPorIdResult()
                    {
                        Id = x.Id,
                        Email = x.Email,
                        Nome = x.Nome,
                        Telefone = x.Telefone,
                        Image = x.Image,
                        Cidade = x.Cidade,
                        Estado = x.Estado
                   };
                }
            );*/
            return new GenericQueryResult(true, "Usuário encontrado", usuario);
        }
    }
}
