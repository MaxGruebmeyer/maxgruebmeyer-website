using Microsoft.AspNetCore.Mvc;
using Website.Interfaces;
using Website.ViewModels;

namespace Website.Controllers;

public class ResourcesController : Controller
{
    private readonly IBookHandler _bookHandler;
    private readonly IVideoHandler _videoHandler;
    private readonly ILogger<ResourcesController> _logger;

    private readonly ResourcesViewModel _viewModel;

    public ResourcesController(IBookHandler bookHandler, IVideoHandler videoHandler,
            ILogger<ResourcesController> logger)
    {
        _bookHandler = bookHandler;
        _videoHandler = videoHandler;

        _logger = logger;

        _viewModel = new ResourcesViewModel
        {
            Books = _bookHandler.GetBooks(),
            Videos = _videoHandler.GetVideos(),
        };
    }

    public IActionResult Index()
    {
        return View(_viewModel);
    }
}
