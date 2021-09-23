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
    public class InteresseRepository : IInteresseRepository
    {
        XptoContext ctx = new XptoContext();

        public void Cadastrar(Interesse novointeresse)
        {
            ctx.Interesses.Add(novointeresse);

            // Salva as informações para serem gravas no banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Interesse interesseBuscado = ctx.Interesses.Find(id);

            ctx.Interesses.Remove(interesseBuscado);

            // Salva as alterações no banco de dados
            ctx.SaveChanges();
        }

        public List<Interesse> BuscarPorId(int id)
        {
            return ctx.Interesses.Where(e => e.IdAnuncio == id).Include(e => e.IdUsuarioNavigation).Include(e => e.IdAnuncioNavigation).ToList();
        }

        public List<Interesse> InteresseDoUsuario(int id)
        {
            return ctx.Interesses.Where(e => e.IdUsuario == id).Include(e => e.IdAnuncioNavigation).ToList();
        }
    }
}
