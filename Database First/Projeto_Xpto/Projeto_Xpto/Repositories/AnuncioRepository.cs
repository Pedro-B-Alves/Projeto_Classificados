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
    public class AnuncioRepository : IAnuncioRepository
    {
        XptoContext ctx = new XptoContext();

        public void Atualizar(int id, Anuncio anuncioAtualizado)
        {

            Anuncio anuncioBuscado = ctx.Anuncios.Find(id);

            if (anuncioAtualizado.Preco != 0)
            {
                // Atribui os novos valores aos campos existentes
                anuncioBuscado.Preco = anuncioAtualizado.Preco;
            }

            if (anuncioAtualizado.Nome != null)
            {
                // Atribui os novos valores aos campos existentes
                anuncioBuscado.Nome = anuncioAtualizado.Nome;
            }

            if (anuncioAtualizado.Descricao != null)
            {
                // Atribui os novos valores aos campos existentes
                anuncioBuscado.Descricao = anuncioAtualizado.Descricao;
            }

            if (anuncioAtualizado.Imagem != null)
            {
                // Atribui os novos valores aos campos existentes
                anuncioBuscado.Imagem = anuncioAtualizado.Imagem;
            }

            ctx.Anuncios.Update(anuncioBuscado);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public Anuncio BuscarPorId(int id)
        {
            Anuncio anuncio = ctx.Anuncios.Include(e => e.IdUsuarioNavigation).FirstOrDefault(x => x.IdAnuncio == id);
            return anuncio;
        }

        public void Cadastrar(Anuncio novoAnuncio)
        {
            ctx.Anuncios.Add(novoAnuncio);

            // Salva as informações para serem gravas no banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Anuncio anuncioBuscado = ctx.Anuncios.Find(id);

            ctx.Anuncios.Remove(anuncioBuscado);

            // Salva as alterações no banco de dados
            ctx.SaveChanges();
        }

        public List<Anuncio> Listar()
        {
            return ctx.Anuncios
                .Include(e => e.IdUsuarioNavigation)
                .ToList();
        }
    }
}
