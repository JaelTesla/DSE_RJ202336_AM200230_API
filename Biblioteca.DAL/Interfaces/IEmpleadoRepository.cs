using Biblioteca.Entites.Models;

namespace Biblioteca.DAL.Interfaces
{
    public interface IEmpleadoRepository
    {      
        public Task<Empleado> GetEmpleado(int id);
        //public Task UpdateEmpleado(int id, decimal NewSalario);
        public Task<Empleado> UpdateEmpleado(Empleado empleado);
    }
}
