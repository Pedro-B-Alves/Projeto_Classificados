using ProjetoClassificados.Comum.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Comum.Handlers.Contracts
{
    public interface IHandlerQuery<T> where T : IQuery
    {
        IQueryResult Handler(T query);
    }
}
