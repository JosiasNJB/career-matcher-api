using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Application.Interfaces;

public interface IConcursoService
{
    List<Concurso> GetAllConcursos();
}