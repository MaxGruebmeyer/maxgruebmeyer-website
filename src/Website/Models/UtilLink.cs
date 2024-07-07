namespace Website.Models;

public class UtilLink : IEquatable<UtilLink>
{
    public string? Name { get; init; }

    // TODO (GM): Change this to URL data type?
    public string? Target { get; init; }
    public string? Description { get; init; }
    public Guid Guid { get; init; }

    public bool Equals(UtilLink? link)
    {
        return link != null && Guid == link.Guid;
    }
}
