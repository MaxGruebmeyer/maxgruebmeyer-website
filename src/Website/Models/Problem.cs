namespace Website.Models;

public class Problem : IEquatable<Problem>
{
    public string? Name { get; init; }
    public string? Description { get; init; }
    public string? Solution { get; init; }
    public Guid Guid { get; init; }

    public bool Equals(Problem? problem)
    {
        return problem != null && Guid == problem.Guid;
    }
}
