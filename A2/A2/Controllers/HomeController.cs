using A2.Data;
using Microsoft.AspNetCore.Mvc;

namespace A2.Controllers;

public class HomeController : Controller 
{
    private readonly ApplicationDbContext _context;
    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var featuredProducts = _context.Products.Where(x=>x.IsFeatured).ToList();
        return View(featuredProducts);
    }
    
    public IActionResult Privacy()
    {
        return View();
    }
}