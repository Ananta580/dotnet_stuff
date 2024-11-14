using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using TorontoWeather;
using TorontoWeatherApp.Models;

namespace TorontoWeatherApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Weather()
    {
        var weatherService = new WeatherService();
        var weather = await weatherService.GetTorontoWeatherAsync();
        ViewBag.Weather = weather;
        return View();
    }
}