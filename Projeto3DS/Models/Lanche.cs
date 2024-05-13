using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto3DS.Models
{
    [Table ("Lanche")]
    public class Lanche
    {
        [MaxLength(200)]
        [MinLength(20)]
        public string descricao_curta { get; set; }
        public string descricao_detalhada { get; set; }
        public bool emEstoque { get; set; }
        [Key]
        public int lancheId { get; set; }
        
        [Required(ErrorMessageResourceName="Inserir nome do lanche")]
        [Display(Name = "Nome dolanche")]
        [StringLength(80, MinimumLength=10, ErrorMessage="Tamanho inválido")]

        public string nome { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99)]
        public decimal preco {get; set;}
        public string imagemURL { get; set; }
        public string lanchePreferido { get; set; }
        


    }
}
