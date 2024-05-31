namespace BlazorAppBook.Domain.Entitites.Book
{
    public class BookEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public Category Category { get; set; }
    }
}
