using AutoMapper;
using Biblioteca.BL.Interfaces;
using Biblioteca.DAL;
using Biblioteca.DAL.Interfaces;
using Biblioteca.Entites.DTO;
using Biblioteca.Entites.Models;
namespace Biblioteca.BL
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository repository;
        private readonly IMapper mapper;

        public EmpleadoService(IEmpleadoRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

       /* public async Task<List<EmpleadoDto>> GetEmpleados()
        {
            try
            {
                var result = await repository.GetEmpleado();
                return mapper.Map<List<EmpleadoDto>>(result);
            }
            catch (Exception ex)
            {

                return new List<EmpleadoDto>();
            }
        }
       */
        public async Task<EmpleadoDto> GetEmpleadoByIdAsync(int id)
        {
            try
            {
                var result = await repository.GetEmpleado(id);
                return mapper.Map<Empleado, EmpleadoDto>(result);

            }
            catch (Exception ex)
            {

                return null;
            }
        }

        /*public async Task UpdateEmpleado(int id, decimal newSalario)
        {
            var empleado = await repository.GetEmpleado(id);
            if (empleado == null) {
                throw new Exception("Empleado no encontrado");
            }
            if (newSalario <= 0)
            {
                throw new ArgumentException("El salario debe ser mayor que cero");
            }

            await repository.UpdateEmpleado(id, newSalario);
        }*/

        public async Task<EmpleadoDto> UpdateEmpleado(EmpleadoDto model)
        {
            try
            {
                var entity = mapper.Map<EmpleadoDto, Empleado>(model);
                var result = await repository.UpdateEmpleado(entity);
                return mapper.Map<Empleado, EmpleadoDto>(result);

            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
