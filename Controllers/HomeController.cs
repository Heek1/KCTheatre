using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace KCDemo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    [Authorize]
    public IActionResult Catalog() => View();

    [Authorize]
    public IActionResult Profile() => View();

    public IActionResult Logout() => SignOut("Cookies", "OpenIdConnect");
}
