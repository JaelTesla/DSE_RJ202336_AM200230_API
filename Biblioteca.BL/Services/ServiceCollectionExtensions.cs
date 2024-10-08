﻿using Biblioteca.BL.Automapper;
using Biblioteca.BL.Interfaces;
using Biblioteca.BL.Services;
using Biblioteca.DAL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Biblioteca.BL.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceConnector(this IServiceCollection services) { 
            services.AddAutoMapper(typeof(AutomapperProfile).Assembly);
            services.AddTransient<IEmpleadoService, EmpleadoService>();
            services.AddRepositoryConnector();
            return services;
        
        }
    }
}
