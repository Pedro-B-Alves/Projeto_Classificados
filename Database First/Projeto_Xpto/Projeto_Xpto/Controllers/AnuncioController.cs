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
    public class AnuncioController : ControllerBase
    {
        private IAnuncioRepository _anuncioRepository { get; set; }

        public AnuncioController()
        {
            _anuncioRepository = new AnuncioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Retorna a resposta da requisição fazendo a chamada para o método
            return Ok(_anuncioRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Retorna a resposta da requisição fazendo a chamada para o método
            return Ok(_anuncioRepository.BuscarPorId(id));
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post(Anuncio novoAnuncio)
        {
            try
            {
                // Faz a chamada para o método
                _anuncioRepository.Cadastrar(novoAnuncio);

                // Retorna um status code
                return StatusCode(201);

            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Put(int id, Anuncio anuncioAtualizado)
        {
            // Faz a chamada para o método
            _anuncioRepository.Atualizar(id, anuncioAtualizado);

            // Retorna um status code
            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            // Faz a chamada para o método
            _anuncioRepository.Deletar(id);

            // Retorna um status code
            return StatusCode(204);
        }
    }
}
