using Website.Models;

namespace Website.Interfaces;

public interface IUtilLinkHandler
{
    public UtilLink? GetLink(Guid guid);

    public IEnumerable<UtilLink> GetLinks();
    public IEnumerable<UtilLink> GetLinks(Predicate<UtilLink> predicate);

    public void AddLink(UtilLink link);
    public void DeleteLink(Guid guid);
}
