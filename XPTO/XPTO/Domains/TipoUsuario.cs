using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace XPTO.Domains
{
    [Table("TiposUsuario")]
    public class TipoUsuario
    {
        [Key]
        // Define o auto-incremento
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTipoUsuario { get; set; }

        // Define o tipo de dado
        [Column(TypeName = "VARCHAR(255)")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "O título do tipo de usuário é obrigatório!")]
        public string titulo { get; set; }
    }
}
