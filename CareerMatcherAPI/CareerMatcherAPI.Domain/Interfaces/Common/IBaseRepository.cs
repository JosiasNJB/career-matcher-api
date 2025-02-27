using CareerMatcherAPI.Domain.Common;

namespace CareerMatcherAPI.Domain.Interfaces.Common;

//A interface recebe um T genérico, porém esse T deve herdar de BaseEntity
public interface IBaseRepository<T> where T : BaseEntity
{
    Task Create(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<bool> Any(Guid id);
    
    /*IQueryable é uma estrutura de query do C# que monta uma query. (uma estrutura que
    consegue buscar dados)*/
    IQueryable<T> GetById(Guid id);
    IQueryable<T> GetAll();
    
    void AddRange(ICollection<T> entities);
    void DeleteRange(ICollection<T> entities);
}
