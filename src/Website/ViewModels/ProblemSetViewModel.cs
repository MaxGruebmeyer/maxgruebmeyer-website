using Website.Models;

namespace Website.ViewModels;

public class ProblemSetViewModel
{
    public ProblemSetViewModel()
    {
        Problems = new List<Problem>();
    }

    public IEnumerable<Problem> Problems { get; init; }
}
