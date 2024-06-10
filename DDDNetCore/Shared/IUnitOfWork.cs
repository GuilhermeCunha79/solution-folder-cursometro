namespace WebApplication1.Shared;

public interface IUnitOfWork
{
    
        Task<int> CommitAsync();
    
}