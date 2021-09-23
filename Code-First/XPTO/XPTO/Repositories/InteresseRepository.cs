using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPTO.Contexts;
using XPTO.Domains;
using XPTO.Interfaces;

namespace XPTO.Repositories
{
    public class InteresseRepository : IInteresseRepository
    {
        XPTOContext ctx = new XPTOContext();

        public void Cadastrar(Interesse novointeresse)
        {
            ctx.Interesse.Add(novointeresse);

            // Salva as informações para serem gravas no banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Interesse interesseBuscado = ctx.Interesse.Find(id);

            ctx.Interesse.Remove(interesseBuscado);

            // Salva as alterações no banco de dados
            ctx.SaveChanges();
        }

        public List<Interesse> BuscarPorId(int id)
        {
            return ctx.Interesse.Where(e => e.idAnuncio == id).ToList();
        }
    }
}
