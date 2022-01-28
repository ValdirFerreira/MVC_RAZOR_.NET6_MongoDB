using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMongoDB.Models
{
    [Table("Usuario")]
    public class Usuario
    {

        [Column("Id")]
        [Display(Name ="Código")]
        public Guid Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
