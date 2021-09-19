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
    public class AnuncioRepositorio : IAnuncioRepositorio
    {

        // Injeção de dependência
        private readonly ProjetoClassificadosContext _context;

        public AnuncioRepositorio(ProjetoClassificadosContext context)
        {
            _context = context;
        }

        public void Alterar(Anuncio anuncio)
        {
            _context.Entry(anuncio).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Anuncio BuscarPorId(Guid id)
        {
            return _context.Anuncios.FirstOrDefault(x => x.Id == id);
        }

        public void Cadastrar(Anuncio anuncio)
        {
            _context.Anuncios.Add(anuncio);
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            _context.Anuncios.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }

        public List<Anuncio> Listar()
        {
            return _context.Anuncios.ToList();
        }

    }
}
