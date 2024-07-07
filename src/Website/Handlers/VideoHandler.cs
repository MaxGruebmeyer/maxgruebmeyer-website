using Website.Interfaces;
using Website.Models;

namespace Website.Handlers;

public class VideoHandler : IVideoHandler
{
    // TODO (GM): Implement a real database (also applies to other handlers)
    private static readonly Dictionary<Guid, Video> _videos = new Dictionary<Guid, Video>();

    public Video? GetVideo(Guid guid)
    {
        return _videos.ContainsKey(guid) ? _videos[guid] : null;
    }

    public IEnumerable<Video> GetVideos()
    {
        return _videos.Values;
    }

    public IEnumerable<Video> GetVideos(Predicate<Video> predicate)
    {
        return _videos.Values.Where(e => predicate(e));
    }

    public void AddVideo(Video video)
    {
        _videos[video.Guid] = video;
    }

    public void DeleteVideo(Guid guid)
    {
        _videos.Remove(guid);
    }
}
