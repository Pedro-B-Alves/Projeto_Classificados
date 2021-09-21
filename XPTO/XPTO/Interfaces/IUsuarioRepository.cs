using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPTO.Domains;

namespace XPTO.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario novoUsuario);

        void Atualizar(int id, Usuario usuarioAtualizado);

        void Deletar(int id);

        Usuario Login(string email, string senha);
    }
}
