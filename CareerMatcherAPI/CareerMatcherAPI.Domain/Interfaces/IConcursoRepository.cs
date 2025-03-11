using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Domain.Interfaces;

public interface IConcursoRepository
{
    Task<List<Concurso>> GetAllConcursosAsync();
    
}