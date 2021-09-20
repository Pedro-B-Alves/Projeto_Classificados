using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Comum.Queries;
using ProjetoClassificados.Dominio.Commands.Autenticacao;
using ProjetoClassificados.Dominio.Commands.Usuario;
using ProjetoClassificados.Dominio.Entidades;
using ProjetoClassificados.Dominio.Handlers.Autenticacao;
using ProjetoClassificados.Dominio.Handlers.Usuarios;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Api.Controllers
{
    [Route("v1/account")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [Route("signup")]
        [HttpPost]
        public GenericCommandResult SignUp(CriarContaCommand command, [FromServices] CriarUsuarioHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }

        [Route("signin")]
        [HttpPost]
        public GenericCommandResult SignIn(LogarCommand command, [FromServices] LogarHandle handle)
        {
            var resultado = (GenericCommandResult)handle.Handler(command);

            if (resultado.Sucesso)
            {
                var token = GenerateJSONWebToken((Usuario)resultado.Data);
                return new GenericCommandResult(resultado.Sucesso, resultado.Mensagem, new { token = token });
            }

            return new GenericCommandResult(false, resultado.Mensagem, resultado.Data);
        }

        [Route("delete")]
        [HttpDelete]
        public GenericCommandResult Delete(DeletarCommand command, [FromServices] DeletarHandler handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }

        [Route("takebyid")]
        [HttpGet]
        public GenericQueryResult TakeById(Guid id, BuscarPorIdUsuarioQuery query, [FromServices] BuscarPorIdUsuarioHandler handle)
        {
            query.Id = id;
            return (GenericQueryResult)handle.Handler(query);
        }

        private string GenerateJSONWebToken(Usuario userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ChaveSecretaProjetoClassificados123"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                new Claim(JwtRegisteredClaimNames.FamilyName, userInfo.Nome),
                new Claim("telefone", userInfo.Telefone.ToString()),
                new Claim("cidade", userInfo.Cidade),
                new Claim("estado", userInfo.Estado),
                new Claim(ClaimTypes.Role, userInfo.TipoUsuario.ToString()),
                new Claim("role", userInfo.TipoUsuario.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, userInfo.Id.ToString())
            };

            var token = new JwtSecurityToken
                (
                    "ProjetoClassificados",
                    "ProjetoClassificados",
                    claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
