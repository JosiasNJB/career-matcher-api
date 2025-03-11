using CareerMatcherAPI.Domain.Interfaces;
using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Infrastructure.Repositories;

public class ProfissaoRepository : IProfissaoRepository
{
    public Task<List<Profissao>> GetAllProfissoesAsync()
    {
        throw new NotImplementedException();
    }
    
}