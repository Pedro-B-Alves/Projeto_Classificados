using ProjetoClassificados.Comum.Handlers.Contracts;
using ProjetoClassificados.Comum.Queries;
using ProjetoClassificados.Dominio.Queries.Anuncios;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoClassificados.Dominio.Queries.Anuncios.ListarAnunciosQuery;

namespace ProjetoClassificados.Dominio.Handlers.Anuncios
{
    public class ListarAnunciosHandle : IHandlerQuery<ListarAnunciosQuery>
    {
        // Injeção de dependencia
        private readonly IAnuncioRepositorio _anucioRepositorio;

        public ListarAnunciosHandle(IAnuncioRepositorio anuncioRepositorio)
        {
            _anucioRepositorio = anuncioRepositorio;
        }

        public IQueryResult Handler(ListarAnunciosQuery query)
        {
            var anuncios = _anucioRepositorio.Listar();

            var retornoAnuncios = anuncios.Select(
                x =>
                {
                    return new ListarAnuncioResult()
                    {
                        Id = x.Id,
                        Nome = x.Nome,
                        Descricao = x.Descricao,
                        Imagem = x.Imagem,
                        Preco = x.Preco
                    };
                }
            );
            return new GenericQueryResult(true, "Anuncios encontrados", retornoAnuncios);
        }

    }
}
