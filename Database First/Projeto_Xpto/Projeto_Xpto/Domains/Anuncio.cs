using System;
using System.Collections.Generic;

#nullable disable

namespace Projeto_Xpto.Domains
{
    public partial class Anuncio
    {
        public Anuncio()
        {
            Interesses = new HashSet<Interesse>();
        }

        public int IdAnuncio { get; set; }
        public int? IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public double Preco { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Interesse> Interesses { get; set; }
    }
}
