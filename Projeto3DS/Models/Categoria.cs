using System.ComponentModel.DataAnnotations;

namespace Projeto3DS.Models
{
    public class Categoria
    {
        public int categoriaId { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessageResourceName = "Inserir nome da categoria")]
        [Display(Name = "Nome da Categoria")]
        public string categoriaNome { get; set; }
        public string descricao { get; set; }
        public string lanche { get; set; }
        public List <Lanche> lanches { get; set; }
    }
}
