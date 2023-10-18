using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Divertido.Models;

namespace Divertido.Controllers;

public class HomeController : Controller
{
    public static List<Usuario> UsersList = new List<Usuario>{
        new Usuario() { Nombre = "Jose", Apellido = "Fernandez" },
        new Usuario() { Nombre = "Miguel", Apellido = "Aliaga" },
        new Usuario() { Nombre = "Sharon", Apellido = "Alison" },
        new Usuario() { Nombre = "Barbara", Apellido = "Aliaga" },

    };
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        string texto = " Este es un texto para comprboar que se estan mandado los textos de tipos string";
        return View("Index", texto);
    }
    [HttpGet]
    [Route("numbers")]
    public IActionResult Numbers()
    {
        int[] num = { 1, 42, 3, 4, 25, 6, 7, 8 };
        return View("Numbers", num);
    }
    [HttpGet]
    [Route("users")]
    public IActionResult Users()
    {

        return View("Users", UsersList);
    }
    [HttpGet]

    [Route("user")]
    public  IActionResult OneUser()
    {
        return View("OneUser", UsersList);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
