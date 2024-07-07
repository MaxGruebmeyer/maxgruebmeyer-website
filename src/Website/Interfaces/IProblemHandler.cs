using Website.Models;

namespace Website.Interfaces;

public interface IProblemHandler
{
    public Problem? GetProblem(Guid guid);

    public IEnumerable<Problem> GetProblems();
    public IEnumerable<Problem> GetProblems(Predicate<Problem> predicate);

    public void AddProblem(Problem problem);
    public void DeleteProblem(Guid guid);
}
