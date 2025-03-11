using CareerMatcherAPI.Domain.Common;

namespace CareerMatcherAPI.Domain.Entities;

public class Candidato : BaseEntity
{
    public string Nome { get; set; }
    public string DataNascimento { get; set; }
    public string Cpf { get;  set; }
    
    public List<Concurso>? ConcursosCandidato { get; set; }
    
    public List<Profissao>? Profissoes { get; set; }
}