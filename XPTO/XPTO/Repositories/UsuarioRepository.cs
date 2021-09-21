using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPTO.Contexts;
using XPTO.Domains;
using XPTO.Interfaces;

namespace XPTO.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        XPTOContext ctx = new XPTOContext();

        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            if (usuarioAtualizado.telefone != 0)
            {
                // Atribui os novos valores aos campos existentes
                usuarioBuscado.telefone = usuarioAtualizado.telefone;
            }

            if (usuarioAtualizado.cidade != null)
            {
                // Atribui os novos valores aos campos existentes
                usuarioBuscado.cidade = usuarioAtualizado.cidade;
            }

            if (usuarioAtualizado.estado != null)
            {
                // Atribui os novos valores aos campos existentes
                usuarioBuscado.estado = usuarioAtualizado.estado;
            }

            ctx.Usuario.Update(usuarioBuscado);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuario.FirstOrDefault(e => e.idUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuario.Add(novoUsuario);

            // Salva as informações para serem gravas no banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            ctx.Usuario.Remove(usuarioBuscado);

            // Salva as alterações no banco de dados
            ctx.SaveChanges();
        }

        public Usuario Login(string email, string senha)
        {
            // Retorna o usuário encontrado através do e-mail e da senha
            return ctx.Usuario.FirstOrDefault(u => u.email == email && u.senha == senha);
        }
    }
}
