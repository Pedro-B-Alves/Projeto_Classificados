using Projeto_Xpto.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XPTO.Interfaces
{
    interface IAnuncioRepository
    {
        List<Anuncio> Listar();

        Anuncio BuscarPorId(int id);

        List<Anuncio> BuscarPorIdUsuario(int id);

        void Cadastrar(Anuncio novoAnuncio);

        void Atualizar(int id, Anuncio anuncioAtualizado);

        void Deletar(int id);
    }
}
