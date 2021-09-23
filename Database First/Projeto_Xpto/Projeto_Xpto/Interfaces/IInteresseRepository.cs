using Projeto_Xpto.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XPTO.Interfaces
{
    interface IInteresseRepository
    {
        void Cadastrar(Interesse novoInteresse);

        List<Interesse> BuscarPorId(int id);

        List<Interesse> InteresseDoUsuario(int id);

        void Deletar(int id);
    }
}
