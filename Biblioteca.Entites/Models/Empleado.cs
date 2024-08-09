using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Entites.Models
{
    public class Empleado
    {
        [Key]
        public int ID { get; set; }
        public required string NombreEmpleado { get; set; }

        public required DateTime FechaNacimiento { get; set; }
        public required DateTime FechaContratacion {get; set; }
        public required decimal SalarioEmpleado { get; set; }

        public string? DesciprionEmpleado {  get; set; }
        [ForeignKey("Departamento")]
        public int DepartamentoId { get; set; }



    }
}
