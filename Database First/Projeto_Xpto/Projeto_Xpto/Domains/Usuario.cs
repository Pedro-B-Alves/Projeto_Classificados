using System;
using System.Collections.Generic;

#nullable disable

namespace Projeto_Xpto.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Anuncios = new HashSet<Anuncio>();
            Interesses = new HashSet<Interesse>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Imagem { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Anuncio> Anuncios { get; set; }
        public virtual ICollection<Interesse> Interesses { get; set; }
    }
}
