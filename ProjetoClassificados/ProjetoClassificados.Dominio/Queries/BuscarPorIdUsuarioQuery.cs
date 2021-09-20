using ProjetoClassificados.Comum.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjetoClassificados.Dominio.Commands.Usuario
{
    public class BuscarPorIdUsuarioQuery : IQuery
    {
        public BuscarPorIdUsuarioQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public void Validar()
        {
            
        }

        public class ProcurarPorIdResult
        {
            public Guid Id { get; set; }
            public string Email { get; set; }
            public string Nome { get; set; }
            public long Telefone { get; set; }
            public string Image { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
        }
    }
}
