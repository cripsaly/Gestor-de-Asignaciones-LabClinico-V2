using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LabClinico.Domain.Core;

namespace LabClinico.Domain.Entities
{
    [Table("Pacientes")]
    public class Paciente : BaseEntity
    {
        [Key]
        [Column("IdPaciente")]
        public new int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; } = string.Empty;

        [StringLength(15)]
        public string Telefono { get; set; } = string.Empty;
    }
}