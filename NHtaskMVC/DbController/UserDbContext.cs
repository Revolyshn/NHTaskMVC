using Microsoft.EntityFrameworkCore;
using NHtaskMVC.Models.DbEntities;

namespace NHtaskMVC.DbController;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}