using CareerMatcherAPI.Domain.Common;

namespace CareerMatcherAPI.Domain.Entities;

public class Concurso : BaseEntity
{
    public int CodConcurso { get; set; }
    public string Orgao { get; set; }
    public string Edital { get; set; }
    
    public List<Candidato>? CandidatosConcurso { get; set; }
    
    public List<Profissao>? ConcursoVagas { get; set; }
}