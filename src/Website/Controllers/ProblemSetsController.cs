using Microsoft.AspNetCore.Mvc;
using Website.Interfaces;
using Website.ViewModels;

namespace Website.Controllers;

public class ProblemSetsController : Controller
{
    private readonly IProblemHandler _problemHandler;
    private readonly ILogger<ProblemSetsController> _logger;

    private readonly ProblemSetViewModel _viewModel;

    public ProblemSetsController(IProblemHandler problemHandler, ILogger<ProblemSetsController> logger)
    {
        _problemHandler = problemHandler;
        _logger = logger;

        _viewModel = new ProblemSetViewModel
        {
            Problems = _problemHandler.GetProblems(),
        };
    }

    public IActionResult Index()
    {
        return View(_viewModel);
    }
}
