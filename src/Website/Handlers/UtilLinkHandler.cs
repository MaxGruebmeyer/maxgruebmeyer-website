using Website.Interfaces;
using Website.Models;

namespace Website.Handlers;

public class UtilLinkHandler : IUtilLinkHandler
{
    private static readonly Dictionary<Guid, UtilLink> _links = new Dictionary<Guid, UtilLink>();

    public UtilLink? GetLink(Guid guid)
    {
        return _links.ContainsKey(guid) ? _links[guid] : null;
    }

    public IEnumerable<UtilLink> GetLinks()
    {
        return _links.Values;
    }

    public IEnumerable<UtilLink> GetLinks(Predicate<UtilLink> predicate)
    {
        return _links.Values.Where(e => predicate(e));
    }

    public void AddLink(UtilLink link)
    {
        _links[link.Guid] = link;
    }

    public void DeleteLink(Guid guid)
    {
        _links.Remove(guid);
    }
}
