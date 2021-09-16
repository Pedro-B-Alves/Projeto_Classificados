using ProjetoClassificados.Comum.Enum;
using ProjetoClassificados.Dominio.Entidades;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Testes.Repositorios
{
    public class FakeUsuarioRepositorio : IUsuarioRepositorio
    {
        public void Adicionar(Usuario usuario)
        {

        }

        public void Alterar(Usuario usuario)
        {

        }

        public void AlterarSenha(Usuario usuario)
        {

        }

        public Usuario BuscarPorEmail(string email)
        {
            if (email == "pedro@email.com")
                return new Usuario("pedro@gmail.com", "pedro1234", "Pedro", 11912345678, "", "São Paulo", "São Paulo", EnTipoUsuario.Admin);
            else
                return null;
        }

        public Usuario BuscarPorId(Guid id)
        {
            return new Usuario("pedro@gmail.com", "pedro1234", "Pedro", 11912345678, "", "São Paulo", "São Paulo", EnTipoUsuario.Admin);
        }

        public void Excluir(Guid id)
        {
            
        }

        public ICollection<Usuario> Listar(bool? ativo = null)
        {
            return new List<Usuario>()
            {
                new Usuario("pedro@gmail.com", "pedro1234", "Pedro", 11912345678, "", "São Paulo", "São Paulo", EnTipoUsuario.Admin)
            };
        }
    }
}
