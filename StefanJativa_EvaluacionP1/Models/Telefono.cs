using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace StefanJativa_EvaluacionP1.Models
{
    public class Telefono
    {
        [Key]
        [NotNull]
        public int Id {  get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public string Modelo { get; set; }

        [NotNull]
        [Range(0, 2025)]
        public int Año { get; set; }

        [NotNull]
        [Range(0, 2025)]
        public float Precio { get; set; }

        
    }
}
