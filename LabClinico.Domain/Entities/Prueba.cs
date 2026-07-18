using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LabClinico.Domain.Core;

namespace LabClinico.Domain.Entities
{
    [Table("Pruebas")]
    public class Prueba : BaseEntity
    {
        [Key]
        [Column("IdPrueba")]
        public new int Id { get; set; }

        [Required]
        [Column("NombrePrueba")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Descripcion { get; set; }
    }
}