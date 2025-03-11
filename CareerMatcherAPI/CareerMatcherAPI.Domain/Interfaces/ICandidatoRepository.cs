using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Domain.Interfaces;

public interface ICandidatoRepository
{
    Task<List<Candidato>> GetAllCandidatosAsync();
    
}