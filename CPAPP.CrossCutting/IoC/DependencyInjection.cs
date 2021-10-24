using System;
using CPAPP.Application.Interfaces;
using CPAPP.Application.Mappings;
using CPAPP.Application.Services;
using CPAPP.Domain.Entities;
using CPAPP.Domain.Interfaces;
using CPAPP.Infrastucture.Context;
using CPAPP.Infrastucture.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace CPAPP.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            // services.AddDbContext<ApplicationDbContext>(options =>
            //     options.UseSqlServer("DefaultConnection"));
            
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                     new MySqlServerVersion(new Version(8, 0, 11))));

            // var connection = configuration["DefaultConnection:ConnectionStrings"];
            // services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(connection));
            
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<IPagamentoService, PagamentoService>();
            
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}