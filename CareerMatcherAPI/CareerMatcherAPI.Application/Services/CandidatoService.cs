using CareerMatcherAPI.Application.Interfaces;
using CareerMatcherAPI.Domain.Entities;
using CareerMatcherAPI.Domain.Interfaces;

namespace CareerMatcherAPI.Application.Services;

public class CandidatoService : ICandidatoService
{
    private readonly ICandidatoRepository _candidatoRepository;
    
    public CandidatoService(ICandidatoRepository candidatoRepository)
    {
        _candidatoRepository = candidatoRepository;
    }
    
    public async Task<List<Candidato>> GetAllCandidatosAsync()
    {
        return await _candidatoRepository.GetAllCandidatosAsync(); 
    }
    
}