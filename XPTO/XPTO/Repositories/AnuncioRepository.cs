using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPTO.Contexts;
using XPTO.Domains;
using XPTO.Interfaces;

namespace XPTO.Repositories
{
    public class AnuncioRepository : IAnuncioRepository
    {
        XPTOContext ctx = new XPTOContext();

        public void Atualizar(int id, Anuncio anuncioAtualizado)
        {

            Anuncio anuncioBuscado = ctx.Anuncio.Find(id);

            if (anuncioAtualizado.preco != 0)
            {
                // Atribui os novos valores aos campos existentes
                anuncioBuscado.preco = anuncioAtualizado.preco;
            }

            if (anuncioAtualizado.nome != null)
            {
                // Atribui os novos valores aos campos existentes
                anuncioBuscado.nome = anuncioAtualizado.nome;
            }

            if (anuncioAtualizado.descricao != null)
            {
                // Atribui os novos valores aos campos existentes
                anuncioBuscado.descricao = anuncioAtualizado.descricao;
            }

            if (anuncioAtualizado.imagem != null)
            {
                // Atribui os novos valores aos campos existentes
                anuncioBuscado.imagem = anuncioAtualizado.imagem;
            }

            ctx.Anuncio.Update(anuncioBuscado);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public Anuncio BuscarPorId(int id)
        {
            Anuncio anuncio = ctx.Anuncio.Include("Interesses").FirstOrDefault(x => x.idAnuncio == id);
            return anuncio;
        }

        public void Cadastrar(Anuncio novoAnuncio)
        {
            ctx.Anuncio.Add(novoAnuncio);

            // Salva as informações para serem gravas no banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Anuncio anuncioBuscado = ctx.Anuncio.Find(id);

            ctx.Anuncio.Remove(anuncioBuscado);

            // Salva as alterações no banco de dados
            ctx.SaveChanges();
        }

        public List<Anuncio> Listar()
        {
            return ctx.Anuncio.ToList();
        }
    }
}
