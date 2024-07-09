using Microsoft.EntityFrameworkCore;
using UserAPI.Models;

namespace UserAPI.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}