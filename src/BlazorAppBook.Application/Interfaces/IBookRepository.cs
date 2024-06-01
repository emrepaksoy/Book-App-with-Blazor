using BlazorAppBook.Domain.Entitites.Book;

namespace BlazorAppBook.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddSync(BookEntity book);
    }
}
