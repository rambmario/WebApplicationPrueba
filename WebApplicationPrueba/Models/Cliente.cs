using System.ComponentModel.DataAnnotations;

namespace WebApplicationPrueba.Models
{
    public class Cliente
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Telefono { get; set; }


    }
}