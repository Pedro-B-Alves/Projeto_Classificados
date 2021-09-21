using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPTO.Domains;

namespace XPTO.Interfaces
{
    interface IInteresseRepository
    {
        void Cadastrar(Interesse novoInteresse);

        Interesse BuscarPorId(int id);

        void Deletar(int id);
    }
}
