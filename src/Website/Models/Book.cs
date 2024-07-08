namespace Website.Models;

public class Book : IEquatable<Book>
{
    public string? Name { get; init; }
    public string? Description { get; init; }
    public string? Url { get; init; }
    public string? ImageUrl { get; init; }
    public Guid Guid { get; init; }

    public Book()
    {
        Guid = Guid.NewGuid();
    }

    public bool Equals(Book? book)
    {
        return book != null && Guid == book.Guid;
    }
}
