using Biblioteca.Entites.DTO;
using Biblioteca.Entites.Models;

namespace Biblioteca.BL.Interfaces
{
    public interface IEmpleadoService
    {
       // public Task<List<Empleado>> GetEmpleados();
        public Task<EmpleadoDto> GetEmpleadoByIdAsync(int id);
        public Task<EmpleadoDto> UpdateEmpleado(EmpleadoDto empleado);
    }
}
