using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Dominio.Commands.Interesse;
using ProjetoClassificados.Dominio.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClassificados.Api.Controllers
{
    [Route("v1/[interest]")]
    [ApiController]
    public class InteresseController : ControllerBase
    {

        [HttpPost]
        [Authorize]
        public GenericCommandResult Create(AdicionarInteresseCommand command, [FromServices] AdicionarInteresseHandle handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }


    }
}
