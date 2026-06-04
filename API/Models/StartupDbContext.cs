using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Models;

public class StartupDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public StartupDbContext(DbContextOptions<StartupDbContext> options) : base(options) { }
        
    public DbSet<Article> Users { get; set; }
    public DbSet<Review> Lobbies { get; set; }
}
