using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MYMANGAS.APPLICATION.Mapping;
using MYMANGAS.APPLICATION.Services.Contracts;
using MYMANGAS.APPLICATION.Services.Implementations;
using MYMANGAS.DOMAIN.Handles;
using MYMANGAS.DOMAIN.Interfaces;
using MYMANGAS.INFRA.Context;
using MYMANGAS.INFRA.Repositories;

namespace MYMANGAS.IOC
{
    public static class Exthensions
    {
        public static IServiceCollection Infraescture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SqlContext>(options => options.UseInMemoryDatabase("Database"));

            services.AddAutoMapper(typeof(CommandToViewModel), typeof(ViewModelToCommand), typeof(ViewModelToDomain));
            services.AddScoped<IMangaRepository, MangaRepository>();
            services.AddScoped<MangaHandle, MangaHandle>();
            services.AddScoped<IMangaService, MangaService>();


            return services;
        }
    }
}
