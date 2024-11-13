using Microsoft.AspNetCore.Mvc;
using A3.Models.ViewModels;

namespace A3.Controllers;

public class HomeController : Controller
{
    // 1a. FileResult Type Demonstrations
    public FileResult FileResultDemo()
    {
        var fileBytes = System.IO.File.ReadAllBytes("wwwroot/images/card.jpg");
        return File(fileBytes, "image/png", "card.jpg");
    }

    // 1b. JSONResult Type Demonstrations
    public JsonResult JsonResultDemo()
    {
        return Json(new
        {
            Name = "Ananta", Age = 26
        });
    }

    // 2. ViewBag and ViewData example
    // 3. Display Fields Using ViewModel
    public IActionResult Index()
    {
        ViewBag.Info = "This data is coming from ViewBag!";
        ViewData["Information"] = "This data is coming from ViewData!";

        var model = new UserViewModel()
        {
            Name = "Ananta Poudel",
            Address = "Kathmandu",
            Email = "anantapoudel580@gmail.com",
            Phone = "9841234567"
        };

        return View(model);
    }

    // 4. Action for PRG pattern
    [HttpPost]
    public IActionResult SubmitForm(string inputData)
    {
        TempData["Theme"] = inputData;
        return RedirectToAction("Result");
    }

    public IActionResult Result()
    {
        ViewBag.ResultData = TempData["Theme"] ?? "light";
        return View();
    }

    // 5a. State Management Demonstrations
    public IActionResult QueryDemo(string message)
    {
        ViewBag.QueryMessage = message;
        return View();
    }

    // 5b. Cookie Management Demonstrations
    public IActionResult SetSession()
    {
        HttpContext.Session.SetString("username", "User name for this session is: anantapoudel");
        return RedirectToAction("GetSession");
    }

    // 5b. Cookie Management Demonstrations
    public IActionResult GetSession()
    {
        ViewBag.SessionMessage = HttpContext.Session.GetString("username") ?? string.Empty;
        return View();
    }
}