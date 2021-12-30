using System.ComponentModel.DataAnnotations;

namespace AplicacionPrueba.Models
{
    public class Zapato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Marca { get; set; }

        [Required]
        [StringLength(50)]
        public string? Modelo { get; set; }

        [Required]
        [StringLength(50)]
        public string? Color { get; set; }

        [StringLength(50)]
        public string? Talle { get; set; }

        [StringLength(50)]
        public string? Tipo { get; set; }

        public string? Imagen { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }
    }
}