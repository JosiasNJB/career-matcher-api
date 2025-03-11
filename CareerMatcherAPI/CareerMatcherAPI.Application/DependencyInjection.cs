using Microsoft.Extensions.DependencyInjection;
using CareerMatcherAPI.Application.Interfaces;
using CareerMatcherAPI.Application.Services;

namespace CareerMatcherAPI.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICandidatoService, CandidatoService>();
        services.AddScoped<IConcursoService, ConcursoService>();
        services.AddScoped<IProfissaoService, ProfissaoService>();
        return services;
    }
}