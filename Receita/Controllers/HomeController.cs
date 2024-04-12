using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Receita.Models;

namespace Receita.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List <Receitas> receitas = [];
        using (StreamReader leitor = new("Data\\receitas.json"))
        {
            string dados = leitor.ReadToEnd();
            receitas = JsonSerializer.Deserialize<List<Receitas>>(dados);
        }
        return View();
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
