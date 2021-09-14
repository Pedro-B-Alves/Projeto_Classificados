using ProjetoClassificados.Dominio.Entidades;
using ProjetoClassificados.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Testes.Repositorios
{
    class FakeAnuncioRepositorio : IAnuncioRepositorio
    {
        public void Alterar(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }

        public Anuncio BuscarPorId(Guid id)
        {
            return new Anuncio("ps5", "ps5 na caixa", "", 1000);
        }

        public void Cadastrar(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Anuncio> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
