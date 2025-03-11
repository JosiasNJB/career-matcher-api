using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Application.Interfaces;

public interface IProfissaoService
{
    List<Profissao> GetAllProfissoes();
}