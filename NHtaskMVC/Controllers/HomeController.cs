using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NHtaskMVC.DbController;
using NHtaskMVC.Models;
using NHtaskMVC.Models.DbEntities;

namespace NHtaskMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private UserDbContext Context { get; }
    
    public HomeController(UserDbContext _context)
    {
        this.Context = _context;
    }
    
    
    public IActionResult Index()
    {

        var users = (from user in this.Context.Users.Take(10)
            select user).ToList();
        return View(users);
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