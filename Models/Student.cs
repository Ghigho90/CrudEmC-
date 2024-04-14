using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GhighoTest.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Informe o nome")]
        [MaxLength(80, ErrorMessage = "O nome deve ter no máximo 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve ter no mínimo 5 caracteres")]
        [DisplayName("Nome Completo")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o e-mail")]
        [EmailAddress(ErrorMessage ="E-mail inválido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public List<Premium> Premiums { get; set; } = new();
    }
}
