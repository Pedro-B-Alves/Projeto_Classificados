using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace XPTO.Domains
{
    [Table("Anuncio")]
    public class Anuncio
    {

        [Key]
        // Define o auto-incremento
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idAnuncio { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "O nome do anúncio é obrigatório!")]
        // Define os requisitos da propriedade
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O nome deve conter entre 3 e 60 caracteres.")]
        public string nome { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "A descrição do anúncio é obrigatória!")]
        // Define os requisitos da propriedade
        [StringLength(255, MinimumLength = 10, ErrorMessage = "A descrição deve conter entre 10 e 255 caracteres.")]
        public string descricao { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string imagem { get; set; }

        [Column(TypeName = "float")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "O preço do anúncio é obrigatório!")]
        public double preco { get; set; }

        [Column(TypeName = "tinyint")]
        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "O id do usuário é obrigatório!")]
        // Define a chave estrangeira
        [ForeignKey("idUsuario")]
        public int? idUsuario { get; set; }

    }
}
