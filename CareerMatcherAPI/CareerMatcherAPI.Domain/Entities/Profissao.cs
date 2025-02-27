using CareerMatcherAPI.Domain.Common;
using CareerMatcherAPI.Domain.Validation;

namespace CareerMatcherAPI.Domain.Entities;

public class Profissao : BaseEntity
{
    private Guid? _idProfissao { get; set; }
    private string _nomeProfissao { get; set; }
    
    public Profissao(Guid idProfissao, string nomeProfissao)
    {   
        var validationErrors = ProfissaoValidation(nomeProfissao);
        if (validationErrors.Count > 0)
        {
            throw new DomainValidationException(validationErrors);
        }
        
        _idProfissao = idProfissao;
        _nomeProfissao = nomeProfissao;
    }
    
    private List<string> ProfissaoValidation(string nomeProfissao)
    {
        var errors = new List<string>();
        
        if (string.IsNullOrEmpty(nomeProfissao))
        {
            errors.Add("Profession name is required.");
        }
        return errors;
    }
    
}