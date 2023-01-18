using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NHtaskMVC.Controllers;
using NHtaskMVC.DbController;
using NHtaskMVC.Models.DbEntities;

namespace NHService.Controllers;

[Route("devices")]
[ApiController]
public class DevicesController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DevicesDbContext _context;

    public DevicesController(ILogger<HomeController> logger, DevicesDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpPost("send")]
    public void Send(Device device)
    {
        _context.Devices.Add(device);

        _context.SaveChanges();

        _logger.LogInformation("Записал объект!!");
    }

    [HttpGet("get")]
    public IActionResult Get()
    {
        var devices = _context.Devices.ToArray();

        _logger.LogInformation("Получил объектов ШТ: {Count}", devices.Length);

        return View(devices);
    }
}