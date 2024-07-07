using Website.Models;

namespace Website.Interfaces;

public interface IVideoHandler
{
    public Video? GetVideo(Guid guid);

    // TODO (GM): Think about if we need paging! (also applies to other handlers)
    public IEnumerable<Video> GetVideos();
    public IEnumerable<Video> GetVideos(Predicate<Video> predicate);

    // TODO (GM): Think about when the Guid shall be generated + document + maybe return a boolean? (also applies to other handlers)
    public void AddVideo(Video video);
    public void DeleteVideo(Guid guid);

    // TODO (GM): Think about if you need an update (also applies to other handlers)
}
