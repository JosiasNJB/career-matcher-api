using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Domain.Interfaces;

public interface IProfissaoRepository
{
    Task<List<Profissao>> GetAllProfissoesAsync();
    
}