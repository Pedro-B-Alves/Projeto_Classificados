using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace XPTO.Domains
{
    [Table("Usuario")]
    public class Usuario : Base
    {
        [Column(TypeName = "VARCHAR(60)")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "O e-mail do usuário é obrigatório!")]
        public string email { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        // Define os requisitos da propriedade
        [StringLength(60, MinimumLength = 8, ErrorMessage = "A senha deve conter entre 8 e 60 caracteres.")]
        public string senha { get; set; }

        [Column(TypeName = "bigint")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "O telefone do usuário é obrigatória!")]
        // Define os requisitos da propriedade
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O telefone deve conter 11 caracteres.")]
        public long telefone { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string imagem { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "A cidade do usuário é obrigatória!")]
        // Define os requisitos da propriedade
        [StringLength(30, MinimumLength = 2, ErrorMessage = "A cidade deve conter entre 2 e 30 caracteres.")]
        public string cidade { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "O estado do usuário é obrigatória!")]
        // Define os requisitos da propriedade
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O estado deve conter entre 2 e 30 caracteres.")]
        public string estado { get; set; }
    }
}
