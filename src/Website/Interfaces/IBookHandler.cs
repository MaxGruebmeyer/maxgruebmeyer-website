using Website.Models;

namespace Website.Interfaces;

public interface IBookHandler
{
    public Book? GetBook(Guid guid);

    public IEnumerable<Book> GetBooks();
    public IEnumerable<Book> GetBooks(Predicate<Book> predicate);

    public void AddBook(Book book);
    public void DeleteBook(Guid guid);
}
