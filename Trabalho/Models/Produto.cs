using System.ComponentModel.DataAnnotations;

namespace Trabalho.Models
{
    public class produto
    {
        [Key]
        //[Display(Name = "ID:")]
        public Guid Id { get; set; }

        //[Required(ErrorMessage = "Informe o Produto")]
        //[Display(Name = "Nome")]
        public string Nome { get; set; }

        //[Required(ErrorMessage = "Informe o Modelo")]
        //[Display(Name = "Modelo")]
        public string Modelo { get; set; }

        //[Required(ErrorMessage = "Informe a Descrição")]
        //[Display(Name = "Descrição")]
        public string Descricao { get; set; }

        //[Required(ErrorMessage = "Informe o Valor")]
        //[Display(Name = "Valor")]

         public int Valor { get; set; }

       

    }
}
