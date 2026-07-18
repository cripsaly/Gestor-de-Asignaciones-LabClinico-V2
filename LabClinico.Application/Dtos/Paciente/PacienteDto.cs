using System;
using System.ComponentModel.DataAnnotations;

namespace LabClinico.Application.Dtos.Paciente
{
    public class PacienteDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(50, ErrorMessage = "El apellido no puede exceder los 50 caracteres.")]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "La cédula es obligatoria.")]
        [RegularExpression(@"^\d{3}-\d{7}-\d{1}$", ErrorMessage = "El formato de la cédula debe ser 001-0000000-0.")]
        public string Cedula { get; set; } = string.Empty;

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateTime FechaNacimiento { get; set; }
    }
}