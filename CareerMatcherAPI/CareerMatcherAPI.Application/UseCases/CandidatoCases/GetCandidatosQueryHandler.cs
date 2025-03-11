using CareerMatcherAPI.Domain.Entities;
using CareerMatcherAPI.Domain.Interfaces;
using MediatR;

namespace CareerMatcherAPI.Application.UseCases.CandidatoCases;

public class GetCandidatosQueryHandler : IRequestHandler<GetCandidatosQuery, List<Candidato>>
{
    private readonly ICandidatoRepository _candidatoRepository;
    
    public GetCandidatosQueryHandler(ICandidatoRepository candidatoRepository)
    {
        _candidatoRepository = candidatoRepository;
    }
    
    public async Task<List<Candidato>> Handle(GetCandidatosQuery request, CancellationToken cancellationToken)
    {
        var candidatos = await _candidatoRepository.GetAllCandidatosAsync();
        return candidatos;
    }
    
}