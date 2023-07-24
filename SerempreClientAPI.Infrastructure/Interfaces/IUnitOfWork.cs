namespace SerempreClientAPI.Infrastructure.Interfaces;

public interface IUnitOfWork
{
    Task SaveAsync(bool isUpdate = false, CancellationToken? cancellationToken = null);
}
