using System.ComponentModel.DataAnnotations;

namespace LabClinicoAPI1.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        [StringLength(11)]
        public string Cedula { get; set; } = string.Empty;
    }
}
