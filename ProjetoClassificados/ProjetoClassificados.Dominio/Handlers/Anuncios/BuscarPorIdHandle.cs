using ProjetoClassificados.Comum.Handlers.Contracts;
using ProjetoClassificados.Comum.Queries;
using ProjetoClassificados.Dominio.Queries.Anuncios;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoClassificados.Dominio.Queries.Anuncios.BuscarPorIdQuery;

namespace ProjetoClassificados.Dominio.Handlers.Anuncios
{
    public class BuscarPorIdHandle : IHandlerQuery<BuscarPorIdQuery>
    {

        private readonly IAnuncioRepositorio _anuncioRepositorio;

        public BuscarPorIdHandle(IAnuncioRepositorio anuncioRepositorio)
        {
            _anuncioRepositorio = anuncioRepositorio;
        }

        public IQueryResult Handler(BuscarPorIdQuery query)
        {
            var anuncio = _anuncioRepositorio.BuscarPorId(id);

            return new GenericQueryResult(true, "Pacote encontrado", anuncio);
        }

    }
}
