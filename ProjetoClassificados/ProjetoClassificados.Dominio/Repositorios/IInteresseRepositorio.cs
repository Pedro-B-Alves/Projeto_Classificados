using ProjetoClassificados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Repositorios
{
    public interface IInteresseRepositorio
    {

        void Adicionar(Usuario usuario, Anuncio anuncio);

        void Excluir(Guid id);

        List<Interesse> Listar (Guid idAnuncio);
        void Adicionar(Interesse interesse);
    }
}
