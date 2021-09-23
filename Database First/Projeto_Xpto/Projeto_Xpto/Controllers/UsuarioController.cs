using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Xpto.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPTO.Interfaces;
using XPTO.Repositories;

namespace XPTO.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            // Faz a chamada para o método
            _usuarioRepository.Cadastrar(novoUsuario);

            // Retorna um status code
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Put(int id, Usuario usuarioAtualizado)
        {
            // Faz a chamada para o método
            _usuarioRepository.Atualizar(id, usuarioAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método
            _usuarioRepository.Deletar(id);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetById(int id)
        {
            // Retorna a resposta da requisição fazendo a chamada para o método
            return Ok(_usuarioRepository.BuscarPorId(id));
        }
    }
}
