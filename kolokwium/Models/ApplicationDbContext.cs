using Microsoft.EntityFrameworkCore;

namespace kolokwium.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
            
    }

    public DbSet<Client> Client { get; set; }
    public DbSet<Subscription> Subscription { get; set; }
    public DbSet<Payment> Payment { get; set; }
}