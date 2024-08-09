using AutoMapper;
using Biblioteca.Entites.DTO;
using Biblioteca.Entites.Models;

namespace Biblioteca.BL.Automapper
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile() {

            CreateMap<Empleado, EmpleadoDto>()
                   .ForMember(destination => destination.Codigo, options => options.MapFrom(source => source.ID))
                   .ForMember(destination => destination.Nombre, options => options.MapFrom(source => source.NombreEmpleado))
                   .ForMember(destination => destination.FechaNac, options => options.MapFrom(source => source.FechaNacimiento))
                   .ForMember(destination => destination.FechaCont, options => options.MapFrom(source => source.FechaContratacion))
                   .ForMember(destination => destination.DepartamentoId, options => options.MapFrom(source => source.DepartamentoId))
                   .ForMember(destination => destination.Salario, options => options.MapFrom(source => source.SalarioEmpleado))
                   .ForMember(destination => destination.Descripcion, options => options.MapFrom(source => source.DesciprionEmpleado))
                   .ReverseMap();
        }
    }
}
