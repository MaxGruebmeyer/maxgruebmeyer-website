using Website.Interfaces;
using Website.Models;

namespace Website.Handlers;

public class BookHandler : IBookHandler
{
    private static readonly Dictionary<Guid, Book> _books = new Dictionary<Guid, Book>();

    public Book? GetBook(Guid guid)
    {
        return _books.ContainsKey(guid) ? _books[guid] : null;
    }

    public IEnumerable<Book> GetBooks()
    {
        return _books.Values;
    }

    public IEnumerable<Book> GetBooks(Predicate<Book> predicate)
    {
        return _books.Values.Where(e => predicate(e));
    }

    public void AddBook(Book book)
    {
        _books[book.Guid] = book;
    }

    public void DeleteBook(Guid guid)
    {
        _books.Remove(guid);
    }
}
