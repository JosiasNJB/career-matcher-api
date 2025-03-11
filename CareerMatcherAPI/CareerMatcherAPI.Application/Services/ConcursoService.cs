using CareerMatcherAPI.Application.Interfaces;
using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Application.Services;

public class ConcursoService : IConcursoService
{
    public List<Concurso> GetAllConcursos()
    {
        return new List<Concurso>
        {
            new Concurso
            {
                Id = new Guid(),
                CodConcurso = 1,
                Orgao = "Polícia Federal",
                Edital = "Edital 1",
                DateCreated = DateTimeOffset.UtcNow
            }
        };
    }
    
}