namespace Website.Models;

public class Book : IEquatable<Book>
{
    public string? Name { get; init; }
    public Guid Guid { get; init; }

    public bool Equals(Book? book)
    {
        return book != null && Guid == book.Guid;
    }
}