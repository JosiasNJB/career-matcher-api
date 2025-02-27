using CareerMatcherAPI.Domain.Entities;
using CareerMatcherAPI.Domain.Interfaces.Common;

namespace CareerMatcherAPI.Domain.Interfaces.Entities;

//Neste caso, por ser um crud simples, essa interface está vazia,
public interface IProfissaoRepository : IBaseRepository<Profissao>
{
}