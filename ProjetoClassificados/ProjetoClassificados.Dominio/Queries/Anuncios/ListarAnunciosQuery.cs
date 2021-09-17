using ProjetoClassificados.Comum.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Queries.Anuncios
{
    public class ListarAnunciosQuery : IQuery
    {

        public void Validar()
        {
            // Não é preciso validar nada aqui
        }

        // Vamos criar uma classe para pegar só o que é fundamental para o usuario
        public class ListarAnuncioResult
        {
            public Guid Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public string Imagem { get; set; }
            public float Preco { get; set; }
        }

    }
}
