using BlazorAppBook.Domain.Entitites.Book;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppBook.Infrastructure.Context
{
    public class BlazorAppBookDbContext : DbContext
    {
        public BlazorAppBookDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        DbSet<BookEntity> Book { get; set; }




    }
}
