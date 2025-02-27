using CareerMatcherAPI.Domain.Common;
using CareerMatcherAPI.Domain.Validation;

namespace CareerMatcherAPI.Domain.Entities;

public class Concurso : BaseEntity
{
     private int _codConcurso { get; set; }
     private string _nome { get; set; }
     private string _edital { get; set; }
     private List<Profissao> _vagas { get; set; }
     
     // TODO: Add functionalities to add Contests to the database inside the API
     // Initialize the concurso with an empty list of professions (AKA: When the contest data comes from the API)
     public Concurso(int codConcurso, string nome, string edital)
     { 
          var validationErrors = ConcursoValidation(codConcurso, nome, edital);
          _codConcurso = codConcurso;
          _nome = nome;
          _edital = edital;
          _vagas = [];
     }    

     // Initialize the concurso with a list of professions (AKA: When the contest data comes from the txt files)
     public Concurso(int codConcurso, string nome, string edital, List<Profissao> vagas)
     { 
          var validationErrors = ConcursoValidation(codConcurso, nome, edital);

          _codConcurso = codConcurso;
          _nome = nome;
          _edital = edital;
          _vagas = vagas;
     }
     
     // Validation when creating a concurso through the API
     private List<string> ConcursoValidation(int codConcurso, string nome, string edital)
     {
          var errors = new List<string>();
          
          if (codConcurso <= 0)
          {
               errors.Add("Concurso code is required.");
          }
          if (string.IsNullOrEmpty(nome))
          {
               errors.Add("Name is required.");
          }
          if (string.IsNullOrEmpty(edital))
          {
               errors.Add("Edital is required.");
          }
          return errors;
     }
     
     // Validation when creating a concurso through the txt file
     private List<string> ConcursosValidation(int codConcurso, string nome, string edital, List<Profissao> vagas)
     {
          var errors = new List<string>();
          
          if (codConcurso <= 0)
          {
               errors.Add("Concurso's code is required.");
          }
          if (string.IsNullOrEmpty(nome))
          {
               errors.Add("Name is required.");
          }
          if (string.IsNullOrEmpty(edital))
          {
               errors.Add("Edital is required.");
          }
          if (vagas.Count == 0)
          {
               errors.Add("At least one profession is required.");
          }
          return errors;
     }
}