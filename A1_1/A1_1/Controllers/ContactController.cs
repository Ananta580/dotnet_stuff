using Microsoft.AspNetCore.Mvc;

namespace A1_1.Controllers;

public class ContactController : Controller
{
    // View to show contact us form
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    // Handle post action after form submitted
    public IActionResult Submit(string name, string email, string message)
    {
        ViewBag.Message = "Your message has been submitted!";
        return View("Index");
    }
}