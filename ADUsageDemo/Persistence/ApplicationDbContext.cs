using ADUsageDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ADUsageDemo.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Person> People { get; set; }
}