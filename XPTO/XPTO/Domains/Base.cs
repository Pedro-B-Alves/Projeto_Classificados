using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace XPTO.Domains
{
    [Table("Base")]
    public class Base
    {
        [Key]
        // Define o auto-incremento
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }

        [Column(TypeName = "DateTime")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "Registre a data")]
        public DateTime DataCriacao { get; set; }
    }
}
