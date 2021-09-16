using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Dominio.Commands.Anuncio;
using ProjetoClassificados.Dominio.Handlers.Anuncios;
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

    }
}
