using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GhighoTest.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Informe o titulo do premium")]
        [MaxLength(80, ErrorMessage = "O titulo do premium deve ter no máximo 80 caracteres")]
        [MinLength(5, ErrorMessage = "O titulo do premium deve ter no mínimo 5 caracteres")]
        [DisplayName("Titulo")]
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        //[GreaterThanToday]
        [DisplayName("Data de Início")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        //[GreaterThanToday]
        [DisplayName("Data de Término")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Informe o aluno")]
        [DisplayName("Aluno")]
        public Guid StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
