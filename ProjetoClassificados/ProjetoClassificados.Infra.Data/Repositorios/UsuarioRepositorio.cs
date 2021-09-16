using Microsoft.EntityFrameworkCore;
using ProjetoClassificados.Dominio.Entidades;
using ProjetoClassificados.Dominio.Repositorios;
using ProjetoClassificados.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Infra.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ProjetoClassificadosContext _context;

        public UsuarioRepositorio(ProjetoClassificadosContext context)
        {
            _context = context;
        }

        public void Adicionar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Alterar(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Usuario BuscarPorEmail(string email)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }

        public Usuario BuscarPorId(Guid id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(Guid id)
        {
            _context.Usuarios.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }

        public ICollection<Usuario> Listar(bool? ativo = null)
        {
            return _context.Usuarios
                .AsNoTracking() 
                .OrderBy(x => x.DataCriacao)
                .ToList();
        }
    }
}
