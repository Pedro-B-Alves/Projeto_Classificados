using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPTO.Domains;

namespace XPTO.Interfaces
{
    interface IAnuncioRepository
    {
        List<Anuncio> Listar();

        Anuncio BuscarPorId(int id);

        void Cadastrar(Anuncio novoAnuncio);

        void Atualizar(int id, Anuncio anuncioAtualizado);

        void Deletar(int id);
    }
}
