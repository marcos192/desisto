using System.ComponentModel.DataAnnotations;

namespace Trabalho.Models
{
    public class Fornecedor
    {
        [Key]
        [Display(Name = "ID:")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Informe o Fornecedor")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        public string Email { get; set; }

        [Display(Name = "Nivel do Operador")]
        public string Nivel { get; set; }



    }
}
