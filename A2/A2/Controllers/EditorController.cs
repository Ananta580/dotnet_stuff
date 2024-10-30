using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace A2.Controllers;

[Authorize(Roles = "Admin, Editor")]
public class EditorController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}