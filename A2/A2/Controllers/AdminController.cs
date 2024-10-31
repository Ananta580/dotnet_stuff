using A2.Models;
using A2.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace A2.Controllers;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly UserManager<A2User> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public AdminController(UserManager<A2User> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult AddUser()
    {
        ViewBag.Roles = _roleManager.Roles.Select(r => new SelectListItem
        {
            Value = r.Name,
            Text = r.Name
        }).ToList();
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> AddUser(RegisterViewModel model)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Roles = _roleManager.Roles.Select(r => new SelectListItem
            {
                Value = r.Name,
                Text = r.Name
            }).ToList();
            return View(model);
        }

        var user = new A2User
        {
            UserName = model.Email, 
            Email = model.Email, 
            FirstName = model.FirstName, 
            LastName = model.LastName,
            DateOfBirth = model.DateOfBirth, 
            Address = model.Address
        };
        
        var result = await _userManager.CreateAsync(user, model.Password);
        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            ViewBag.Roles = _roleManager.Roles.Select(r => new SelectListItem
            {
                Value = r.Name,
                Text = r.Name
            }).ToList();
            return View(model);
        }

        if (!await _roleManager.RoleExistsAsync(model.Role))
        {
            await _roleManager.CreateAsync(new IdentityRole(model.Role));
        }

        var roleResult = await _userManager.AddToRoleAsync(user, model.Role);
        if (!roleResult.Succeeded)
        {
            foreach (var error in roleResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }
        return RedirectToAction("Index", "Admin");
    }
}