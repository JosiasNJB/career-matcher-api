using CareerMatcherAPI.Domain.Common;

namespace CareerMatcherAPI.Domain.Entities;

public class Profissao : BaseEntity
{
    public string NomeProfissao { get; set; }
    
    public List<Candidato>? ProfissaoCandidatos { get; set; }
    
    public List<Concurso>? VagaConcursos { get; set; }

}