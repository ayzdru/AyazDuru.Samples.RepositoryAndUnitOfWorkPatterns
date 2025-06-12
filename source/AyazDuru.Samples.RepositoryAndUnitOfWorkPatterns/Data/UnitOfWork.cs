using AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Entities;
using AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Interfaces;
using System;

namespace AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IRepository<Product> Products { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Products = new Repository<Product>(_context);
        }

        public async Task<int> CommitAsync() => await _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }
}
