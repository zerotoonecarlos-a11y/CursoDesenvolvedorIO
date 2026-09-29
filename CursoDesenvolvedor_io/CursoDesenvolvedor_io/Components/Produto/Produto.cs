using Humanizer;
using System.ComponentModel.DataAnnotations;


namespace CursoDesenvolvedor_io.Components.Produto
{
    public class Produto
    {

        [Key]
        public int ID { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome do produto é obrigatoriio")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "A Categoria do produto é obrigatoriio")]
        public string Categoria { get; set; }
        
        [Display(Name = "Preço")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço tem que ser maior que zero")]
        public string Preco { get; set; }

        [Display(Name = "Disponivel?")]
        [Required(ErrorMessage = "E necessario informar se o produto esta disponivel em estoque")]
        public bool Disponivel { get; set; }

        [Display(Name = "Data de Validade")]
        [Required(ErrorMessage = "A data da validade e obrigatoria")]
        public DateTime Datavalidade { get; set; } 
    }
}
