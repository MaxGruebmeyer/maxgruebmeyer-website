using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers;

public class ResourcesController : Controller
{
    private readonly ILogger<ResourcesController> _logger;

    public ResourcesController(ILogger<ResourcesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
