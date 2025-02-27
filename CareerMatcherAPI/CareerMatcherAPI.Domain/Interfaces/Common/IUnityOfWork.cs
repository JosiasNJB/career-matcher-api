namespace CareerMatcherAPI.Domain.Interfaces.Common;

public interface IUnitOfWork
{
    Task Commit(CancellationToken cancellationToken);
}
