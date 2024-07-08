using Microsoft.AspNetCore.Mvc;
using Website.Interfaces;
using Website.ViewModels;

namespace Website.Controllers;

public class ResourcesController : Controller
{
    private readonly IBookHandler _bookHandler;
    private readonly IVideoHandler _videoHandler;
    private readonly IProblemHandler _problemHandler;
    private readonly ILogger<ResourcesController> _logger;

    private readonly ResourcesViewModel _viewModel;

    public ResourcesController(IBookHandler bookHandler, IVideoHandler videoHandler,
            IProblemHandler problemHandler, ILogger<ResourcesController> logger)
    {
        _bookHandler = bookHandler;
        _videoHandler = videoHandler;
        _problemHandler = problemHandler;

        _logger = logger;

        _viewModel = new ResourcesViewModel
        {
            Books = _bookHandler.GetBooks(),
            Videos = _videoHandler.GetVideos(),
            Problems = _problemHandler.GetProblems(),
        };
    }

    public IActionResult Index()
    {
        return View(_viewModel);
    }
}
