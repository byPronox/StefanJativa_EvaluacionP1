using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace StefanJativa_EvaluacionP1.Models
{
    public class Persona
    {
        [Key]
        [NotNull]
        public int Id { get; set; }

        [NotNull]
        [Range(0 ,100000)]
        public float Salario { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public string Apellido { get; set; }

        [NotNull]
        public bool Casado { get; set; }

        
        public DateTime FechaNacimento { get; set; }

        [ForeignKey("Telefono")]
        public int Telefonos { get; set; }
        public Telefono? Telefono { get; set; }
    }
}
