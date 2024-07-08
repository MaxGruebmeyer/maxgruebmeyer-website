using Website.Models;

namespace Website.ViewModels;

public class ResourcesViewModel
{
    public ResourcesViewModel()
    {
        Books = new List<Book>();
        Videos = new List<Video>();
    }

    public IEnumerable<Book> Books { get; init; }
    public IEnumerable<Video> Videos { get; init; }
}
