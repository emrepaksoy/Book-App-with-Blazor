using BlazorAppBook.Application.Interfaces;
using BlazorAppBook.Domain.Entitites.Book;
using BlazorAppBook.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

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

        public async Task DeleteAsync(int id)
        {
            var book = await GetByIdAsync(id);
            if(book is not null)
            {
                _context.Book.Remove(book);
               await  _context.SaveChangesAsync();
            }
        }

        public async Task<List<BookEntity>> GetAllAsync()
        {
            return await _context.Book.ToListAsync();
        }

        public async Task<BookEntity?> GetByIdAsync(int id)
        {
           var book = await _context.Book.FirstOrDefaultAsync(e => e.Id == id);
            return book;
        }

        public async Task UpdateAsync(BookEntity book)
        {
           _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();  
        }
    }
}
