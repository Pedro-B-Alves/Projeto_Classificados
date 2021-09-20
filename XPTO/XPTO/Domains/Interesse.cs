using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace XPTO.Domains
{
    [Table("Interesse")]
    public class Interesse
    {
        [Key]
        // Define o auto-incremento
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idInteresse { get; set; }

        [Column(TypeName = "tinyint")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "O id do usuário é obrigatório!")]
        public int idUsuario { get; set; }

        [Column(TypeName = "tinyint")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "O id do anúncio é obrigatório!")]
        public int idAnuncio { get; set; }

        // Define a chave estrangeira
        [ForeignKey("idUsuario")]
        public Usuario usuario { get; set; }

        // Define a chave estrangeira
        [ForeignKey("idAnuncio")]
        public Anuncio anuncio { get; set; }
    }
}
