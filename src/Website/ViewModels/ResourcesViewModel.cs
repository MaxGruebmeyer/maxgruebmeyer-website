using Website.Models;

namespace Website.ViewModels;

public class ResourcesViewModel
{
    public ResourcesViewModel()
    {
        Books = new List<Book>();
        Videos = new List<Video>();
        Problems = new List<Problem>();
    }

    public IEnumerable<Book> Books { get; init; }
    public IEnumerable<Video> Videos { get; init; }
    public IEnumerable<Problem> Problems { get; init; }
}
