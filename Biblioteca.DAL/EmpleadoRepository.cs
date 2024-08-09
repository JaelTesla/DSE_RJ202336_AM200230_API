using Biblioteca.DAL.Interfaces;
using Biblioteca.Entites.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAL
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly IDatabaseRepository databaseRepository;

        public EmpleadoRepository(IDatabaseRepository databaseRepository)
        {
            this.databaseRepository = databaseRepository;
        }

        public async Task<Empleado> GetEmpleado(int id)
        {
            string query = "SELECT * FROM Empleados WHERE ID = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            return (await databaseRepository.GetDataByQueryAsync<Empleado>(query, parameters)).FirstOrDefault();
        }

       /* public async Task UpdateEmpleado(int id, decimal newSalario)
        {
            string query = "UPDATE Empleados SET SalarioEmpleado = @Salario WHERE ID = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id",id);
            parameters.Add("@Salario", newSalario);

            // o <Empleado>
            await databaseRepository.Update<int>(query, parameters);
        }*/

        public async Task<Empleado> UpdateEmpleado(Empleado empleado)
        {
            string query = "UPDATE Empleados SET SalarioEmpleado = @SalarioEmpleado WHERE ID= @Id";
            var parameters = new DynamicParameters();
            parameters.Add("@Id", empleado.ID);
            parameters.Add("@SalarioEmpleado", empleado.SalarioEmpleado);
            await databaseRepository.Update<Empleado>(query, parameters);
            return empleado;

        }
    }
}
