using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers;

public class ResourcesController : Controller
{
    private readonly ILogger<ResourcesController> _logger;

    public ResourcesController(ILogger<ResourcesController> logger)
    {
        _logger = logger;
    }

    // TODO (GM):
    // - Recommended Books
    // - Recommended Videos
    // - Lecture Notes - possibly german only
    // - Interesting Research Papers

    public IActionResult Index()
    {
        return View();
    }
}
