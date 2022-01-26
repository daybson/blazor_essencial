using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblyForm.Model
{
    public class Usuario
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="Nome deve ser informado"), MinLength(2), MaxLength(50, ErrorMessage ="Nome não pode ter mais de 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email deve ser informado"), EmailAddress(ErrorMessage ="Formtato de email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Idade deve ser informada")]
        [Range(18, 150, ErrorMessage = "Idade deve ser entre 18 e 150")]
        public int Idade { get; set; }

    }
}
