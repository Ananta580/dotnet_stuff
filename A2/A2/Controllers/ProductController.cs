using Microsoft.AspNetCore.Mvc;

namespace A2.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}