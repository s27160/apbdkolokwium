using Microsoft.EntityFrameworkCore;

namespace kolokwium.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
            
    }

    public DbSet<Client> Clients { get; set; }
}