using System;
using System.Collections.Generic;

#nullable disable

namespace Projeto_Xpto.Domains
{
    public partial class Interesse
    {
        public int IdInteresse { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdAnuncio { get; set; }

        public virtual Anuncio IdAnuncioNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
