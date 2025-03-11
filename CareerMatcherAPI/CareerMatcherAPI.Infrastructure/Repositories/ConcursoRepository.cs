using CareerMatcherAPI.Domain.Interfaces;
using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Infrastructure.Repositories;

public class ConcursoRepository : IConcursoRepository
{
    public Task<List<Concurso>> GetAllConcursosAsync()
    {
        throw new NotImplementedException();
    }
    
}