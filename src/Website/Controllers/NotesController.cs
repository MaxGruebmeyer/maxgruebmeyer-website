using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers;

public class NotesController : Controller
{
    private readonly ILogger<NotesController> _logger;

    public NotesController(ILogger<NotesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
