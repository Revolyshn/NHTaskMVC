using Microsoft.EntityFrameworkCore;
using NHtaskMVC.Models.DbEntities;

namespace NHtaskMVC.DbController;

public class DevicesDbContext : DbContext
{
    public DevicesDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Device> Devices { get; set; }
}