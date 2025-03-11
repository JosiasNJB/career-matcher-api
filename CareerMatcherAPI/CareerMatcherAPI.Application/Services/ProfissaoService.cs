using CareerMatcherAPI.Application.Interfaces;
using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Application.Services;

public class ProfissaoService : IProfissaoService
{
    public List<Profissao> GetAllProfissoes()
    {
        return new List<Profissao>
        {
            new Profissao
            {
                Id = new Guid(),
                NomeProfissao = "Desenvolvedor",
                DateCreated = DateTimeOffset.UtcNow
            }
        };
    }
    
}