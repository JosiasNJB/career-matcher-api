using CareerMatcherAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using CareerMatcherAPI.Infrastructure.Context;
using CareerMatcherAPI.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CareerMatcherAPI.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        
        services.AddScoped<ICandidatoRepository, CandidatoRepository>();
        services.AddScoped<IConcursoRepository, ConcursoRepository>();
        services.AddScoped<IProfissaoRepository, ProfissaoRepository>();
        
        return services;
    }
}