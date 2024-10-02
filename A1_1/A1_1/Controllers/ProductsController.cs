using Microsoft.AspNetCore.Mvc;

namespace A1_1.Controllers;

public class ProductsController : Controller
{
    // Index page to list all products
    public IActionResult Index()
    {
        return View();
    }
}