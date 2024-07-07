using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers;

public class UtilController : Controller
{
    private readonly ILogger<UtilController> _logger;

    public UtilController(ILogger<UtilController> logger)
    {
        _logger = logger;
    }

    // TODO (GM):
    // - Hex/Bin Converter
    // - Binomialkoeffizient
    // - Integralrechner
    // - Differentialrechner
    // - String-Compare

    public IActionResult Index()
    {
        return View();
    }
}
