using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers;

public class ProblemSetsController : Controller
{
    private readonly ILogger<ProblemSetsController> _logger;

    public ProblemSetsController(ILogger<ProblemSetsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
