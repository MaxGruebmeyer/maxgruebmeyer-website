using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers;

public class UtilController : Controller
{
    private readonly ILogger<UtilController> _logger;

    public UtilController(ILogger<UtilController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    // TODO (GM): Binomialkoeffizient-Rechner schreiben!
}
