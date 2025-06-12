using AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AyazDuru.Samples.RepositoryAndUnitOfWorkPatterns.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Product> Products => Set<Product>();
    }
}
