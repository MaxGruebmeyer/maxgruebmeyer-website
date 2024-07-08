using Microsoft.AspNetCore.Mvc;
using Website.Interfaces;
using Website.ViewModels;

namespace Website.Controllers;

public class UtilController : Controller
{
    private IUtilLinkHandler _utilLinkHandler;
    private readonly ILogger<UtilController> _logger;

    private UtilViewModel _viewModel;

    public UtilController(IUtilLinkHandler utilLinkHandler, ILogger<UtilController> logger)
    {
        _utilLinkHandler = utilLinkHandler;
        _logger = logger;

        _viewModel = new UtilViewModel
        {
            UtilLinks = _utilLinkHandler.GetLinks(),
        };
    }

    public IActionResult Index()
    {
        return View(_viewModel);
    }

    // TODO (GM): Binomialkoeffizient-Rechner schreiben!
}
