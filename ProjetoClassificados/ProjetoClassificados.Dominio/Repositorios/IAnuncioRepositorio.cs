using ProjetoClassificados.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Repositorios
{
    public interface IAnuncioRepositorio
    {

        void Cadastrar(Anuncio anuncio);
        void Alterar(Anuncio anuncio);
        void Deletar(Guid id);
        Anuncio BuscarPorId(Guid id);
        List<Anuncio> Listar();

    }
}
