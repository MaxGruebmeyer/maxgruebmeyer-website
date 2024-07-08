namespace Website.Models;

public class Video : IEquatable<Video>
{
    public string? Name { get; init; }

    // TODO (GM): Change this to URL data type?
    public string? Url { get; init; }
    public Guid Guid { get; init; }

    public Video()
    {
        Guid = Guid.NewGuid();
    }

    public bool Equals(Video? video)
    {
        return video != null && Guid == video.Guid;
    }
}
