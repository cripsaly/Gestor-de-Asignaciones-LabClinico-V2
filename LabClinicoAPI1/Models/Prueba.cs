using System.ComponentModel.DataAnnotations;

namespace LabClinicoAPI1.Models
{
    public class Prueba
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NombrePrueba { get; set; } = string.Empty;

        [Required]
        public decimal Costo { get; set; }
    }
}