using BlazorAppBook.Application.Interfaces;
using BlazorAppBook.Domain.Entitites.Book;
using BlazorAppBook.Infrastructure.Context;

namespace BlazorAppBook.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BlazorAppBookDbContext _context;

        public BookRepository(BlazorAppBookDbContext context)
        {
            _context = context;
        }

        public async Task AddSync(BookEntity book)
        {
            _context.Book.Add(book);
            await _context.SaveChangesAsync();
        }
    }
}
