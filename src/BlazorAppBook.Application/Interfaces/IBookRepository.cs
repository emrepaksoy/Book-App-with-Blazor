using BlazorAppBook.Domain.Entitites.Book;

namespace BlazorAppBook.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddSync(BookEntity book);
        Task<List<BookEntity>> GetAllAsync();
        Task<BookEntity?> GetByIdAsync(int id);
        Task UpdateAsync(BookEntity book);
        Task DeleteAsync(int id);
    }
}
