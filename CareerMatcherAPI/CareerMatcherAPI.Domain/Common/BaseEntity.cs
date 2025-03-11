using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CareerMatcherAPI.Domain.Common;

public abstract class BaseEntity
{
    // Identificador único da entidade. Mesmo que um item seja excluído, esse ID nunca será repetido.
    [Key]
    public Guid Id { get; set; }

    // Data em que a entidade foi criada
    public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;

    // Data da última atualização da entidade (pode ser nula caso nunca tenha sido atualizada)
    public DateTimeOffset? DateUpdated { get; set; }

    // Data em que a entidade foi deletada (nula se ainda não foi removida)
    public DateTimeOffset? DateDeleted { get; set; }

    // Método para definir um novo ID único ao criar uma entidade
    public void Create()
    {
        Id = Guid.NewGuid();
    }

    // Método para atualizar os atributos de uma entidade sem sobrescrever o ID e a data de criação
    public void Update(BaseEntity entity)
    {
        // Percorre todas as propriedades da entidade recebida como parâmetro
        foreach (PropertyInfo property in entity.GetType().GetProperties())
        {
            // Só atualiza propriedades que podem ser escritas e que não sejam o ID ou a data de criação
            if (property.CanWrite && property.Name != nameof(Id) && property.Name != nameof(DateCreated))
            {
                property.SetValue(this, property.GetValue(entity));
            }
        }

        // Atualiza a data de modificação para o momento atual
        this.DateUpdated = DateTimeOffset.Now;
    }

    // Método para marcar a entidade como deletada
    public void Delete()
    {
        this.DateDeleted = DateTimeOffset.Now;
    }
}
