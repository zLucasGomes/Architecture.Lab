using DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infra.Database;

public class CustomDbContext(DbContextOptions<CustomDbContext> options) : DbContext(options)
{
    public DbSet<Anime> Anime { get; set; } = null!;
    public DbSet<Movie> Movie { get; set; } = null!;
}
