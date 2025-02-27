using CareerMatcherAPI.Domain.Common;
using CareerMatcherAPI.Domain.Validation;

namespace CareerMatcherAPI.Domain.Entities;

public class Candidato : BaseEntity
{
    private string _nome { get; set; }
    private string _dataNascimento { get; set; }
    private string _cpf { get; set; }
    private List<Profissao>? _profissoes { get; set; }
    
    // TODO: Add functionalities to add Candidates to the database inside the API
    // Constructor to initialize the entity
    public Candidato(string nome, string dataNascimento, string cpf)
    {
        var validationErrors = CandidatoValidation(nome, dataNascimento, cpf);
        if (validationErrors.Count > 0)
        {
            throw new DomainValidationException(validationErrors);
        }
        
        _nome = nome;
        _dataNascimento = dataNascimento;
        _cpf = cpf;
    }
    
    // Constructor to initialize the entity with professions(AKA: When the candidate data comes from the txt files)
    public Candidato(string nome, string dataNascimento, string cpf, List<Profissao> profissoes)
    {
        var validationErrors = CandidatoValidation(nome, dataNascimento, cpf, profissoes);
        if (validationErrors.Count > 0)
        {
            throw new DomainValidationException(validationErrors);
        }
        
        _nome = nome;
        _dataNascimento = dataNascimento;
        _cpf = cpf;
    }
    
    // Validation when creating a candidate through the API
    private List<string>CandidatoValidation(string nome, string data_nascimento, string cpf)
    {
        var errors = new List<string>();
        
        if (string.IsNullOrEmpty(nome))
        {
            errors.Add("Name is required.");
        }
        if (string.IsNullOrEmpty(data_nascimento))
        {
            errors.Add("Date of birth is required.");
        }
        if (string.IsNullOrEmpty(cpf))
        {
            errors.Add("CPF is required.");
        }
        return errors;
    }
    
    // TODO: Specify when/why use this method overide
    // Validation when creating a candidate through the txt files
    private List<string>CandidatoValidation(string nome, string data_nascimento, string cpf, List<Profissao> profissoes)
    {
        var errors = new List<string>();
        
        if (string.IsNullOrEmpty(nome))
        {
            errors.Add("Name is required.");
        }
        if (string.IsNullOrEmpty(data_nascimento))
        {
            errors.Add("Date of birth is required.");
        }
        if (string.IsNullOrEmpty(cpf))
        {
            errors.Add("CPF is required.");
        }
        if (profissoes.Count == 0)
        {
            errors.Add("At least one profession is required.");
        }
        return errors;
    }
}