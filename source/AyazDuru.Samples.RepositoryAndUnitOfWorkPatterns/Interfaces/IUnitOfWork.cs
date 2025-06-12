using AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Entities;

namespace AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> Products { get; }
        Task<int> CommitAsync();
    }
}
