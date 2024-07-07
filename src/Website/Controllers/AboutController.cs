using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers;

public class AboutController : Controller
{
    private readonly ILogger<AboutController> _logger;

    public AboutController(ILogger<AboutController> logger)
    {
        _logger = logger;
    }

    // TODO (GM):
    // - Projects Page
    // - Link to GitHub
    // - CV
    // - Contact Me (Contact Information + Mail Sending Service)

    public IActionResult Index()
    {
        return View();
    }
}
