using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Application.Interfaces;

public interface ICandidatoService
{
    Task<List<Candidato>> GetAllCandidatosAsync();
}