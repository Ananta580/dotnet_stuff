using Microsoft.AspNetCore.Mvc;

namespace A1_1.Controllers;

public class AboutController : Controller
{
    // Index page to show map and about us section
    public IActionResult Index()
    {
        return View();
    }
}