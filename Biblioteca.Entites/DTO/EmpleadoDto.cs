
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Entites.DTO
{
    public class EmpleadoDto
    {
        public int Codigo { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "El nombre del empleado es requerido")]
        [Display(Name = "Nombre de Empleado")]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNac { get; set; }

        [Required]
        [Display(Name = "Fecha de Contratación")]
        [DataType(DataType.Date)]
        public DateTime FechaCont { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El salario debe ser mayor que cero.")]
        public decimal Salario { get; set; }

        [Display(Name = "Descripción de Empleado")]
        public string? Descripcion { get; set; }

        
        [Required]
        [ForeignKey("Departamento")]
        public int? DepartamentoId { get; set; }
    }
}
