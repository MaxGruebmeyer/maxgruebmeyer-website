using Website.Interfaces;
using Website.Models;

namespace Website.Handlers;

public class ProblemHandler : IProblemHandler
{
    private static readonly Dictionary<Guid, Problem> _problems = new Dictionary<Guid, Problem>();

    public Problem? GetProblem(Guid guid)
    {
        return _problems.ContainsKey(guid) ? _problems[guid] : null;
    }

    public IEnumerable<Problem> GetProblems()
    {
        return _problems.Values;
    }

    public IEnumerable<Problem> GetProblems(Predicate<Problem> predicate)
    {
        return _problems.Values.Where(e => predicate(e));
    }

    public void AddProblem(Problem problem)
    {
        _problems[problem.Guid] = problem;
    }

    public void DeleteProblem(Guid guid)
    {
        _problems.Remove(guid);
    }
}
