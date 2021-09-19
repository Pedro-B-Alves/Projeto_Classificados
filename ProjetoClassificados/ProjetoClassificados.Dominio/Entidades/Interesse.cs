using ProjetoClassificados.Comum.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Entidades
{
    public class Interesse : Entidade
    {
        public Interesse(Guid idUsuario, Guid idAnuncio)
        {
            IdUsuario = idUsuario;
            IdAnuncio = idAnuncio;
        }

        public Guid IdUsuario { get; private set; }
        public Usuario usuario { get; private set; }

        public Guid IdAnuncio { get; private set; }
        public Anuncio anuncio { get; private set; }

    }
}
