using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace TheatreDemo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    [Authorize]
    public IActionResult Catalog() => View();

    public IActionResult Profile() => View();

    [Authorize(Roles = "admin")]
    public IActionResult Admin() => View();

    [Authorize(Roles = "guest")]
    public IActionResult Guest() => View();

    public IActionResult AccessDenied() => View();

    public IActionResult Logout() => SignOut("Cookies", "OpenIdConnect");
}
