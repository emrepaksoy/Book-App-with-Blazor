using BlazorAppBook.Domain.Entitites.Book;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppBook.Infrastructure.Context
{
    public class BlazorAppBookDbContext : DbContext
    {
        public BlazorAppBookDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<BookEntity> Book { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
