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
    public class InteresseRepositorio : IInteresseRepositorio
    {



        private readonly ProjetoClassificadosContext _context;

        public InteresseRepositorio(ProjetoClassificadosContext context)
        {
            _context = context;
        }

        public void Adicionar(Usuario usuario, Anuncio anuncio)
        {
            _context.Anuncios.Add(anuncio);
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Adicionar(Interesse interesse)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Interesse> Listar(Guid idAnuncio)
        {
            throw new NotImplementedException();
        }
    }
}
