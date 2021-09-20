using ProjetoClassificados.Comum.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Queries.Anuncios
{
    public class BuscarPorIdQuery : IQuery
    {

        public void Validar()
        {
            // não precisa validar nada aqui neste caso
        }

        public class BuscarPorIdResult
        {
            public Guid Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public string Imagem { get; set; }
            public float Preco { get; set; }
        }

    }
}
