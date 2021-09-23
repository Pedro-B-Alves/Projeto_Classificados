using Microsoft.EntityFrameworkCore;
using Projeto_Xpto.Contexts;
using Projeto_Xpto.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPTO.Interfaces;

namespace XPTO.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        XptoContext ctx = new XptoContext();

        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);

            if (usuarioAtualizado.Telefone != null)
            {
                // Atribui os novos valores aos campos existentes
                usuarioBuscado.Telefone = usuarioAtualizado.Telefone;
            }

            if (usuarioAtualizado.Cidade != null)
            {
                // Atribui os novos valores aos campos existentes
                usuarioBuscado.Cidade = usuarioAtualizado.Cidade;
            }

            if (usuarioAtualizado.Estado != null)
            {
                // Atribui os novos valores aos campos existentes
                usuarioBuscado.Estado = usuarioAtualizado.Estado;
            }

            ctx.Usuarios.Update(usuarioBuscado);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            Usuario usuario = ctx.Usuarios.Include(e => e.IdTipoUsuarioNavigation).FirstOrDefault(e => e.IdUsuario == id);

            return usuario;
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            // Salva as informações para serem gravas no banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(usuarioBuscado);

            // Salva as alterações no banco de dados
            ctx.SaveChanges();
        }

        public Usuario Login(string email, string senha)
        {
            // Retorna o usuário encontrado através do e-mail e da senha
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
