using AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();
        public async Task<T?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);
        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);
        public void Remove(T entity) => _dbSet.Remove(entity);
    }
}
