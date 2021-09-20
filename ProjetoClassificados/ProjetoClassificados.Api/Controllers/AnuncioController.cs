using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Comum.Queries;
using ProjetoClassificados.Dominio.Commands.Anuncio;
using ProjetoClassificados.Dominio.Handlers.Anuncios;
using ProjetoClassificados.Dominio.Queries.Anuncios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClassificados.Api.Controllers
{
    [Route("v1/announcement")]
    [ApiController]
    public class AnuncioController : ControllerBase
    {

        [Route("register")]
        [HttpPost]
        public GenericCommandResult Register(CriarAnuncioCommand command, [FromServices] CriarAnuncioHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }

        [Route("delete")]
        [HttpDelete]
        public GenericCommandResult Delete(DeletarAnuncioCommand command, [FromServices] DeletarAnuncioHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }

        [Route("list")]
        [HttpGet]
        public GenericQueryResult List([FromServices] ListarAnunciosHandle handle)
        {
            ListarAnunciosQuery query = new ListarAnunciosQuery();

            return (GenericQueryResult)handle.Handler(query);
        }

        [Route("takeById")]
        [HttpGet("{id}")]
        public GenericQueryResult takeById([FromServices] BuscarPorIdHandle handle)
        {
            BuscarPorIdQuery query = new BuscarPorIdQuery();

            return (GenericQueryResult)handle.Handler(query);
        }

    }
}
