using Website.Models;

namespace Website.ViewModels;

public class UtilViewModel
{
    public UtilViewModel()
    {
        UtilLinks = new List<UtilLink>();
    }

    public IEnumerable<UtilLink> UtilLinks { get; init; }
}
