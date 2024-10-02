using Microsoft.AspNetCore.Mvc;

namespace A1_1.Controllers;

public class ServicesController : Controller
{
    // Index page to list all the services
    public IActionResult Index()
    {
        return View();
    }
}