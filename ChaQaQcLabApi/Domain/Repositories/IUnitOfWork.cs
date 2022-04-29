namespace ChaQaQcLabApi.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}
