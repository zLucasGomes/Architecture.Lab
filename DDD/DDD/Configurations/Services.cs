using DDD.Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace DDD.Configurations;

public static class Services
{
    public static IServiceCollection ConfigureService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CustomDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("Database")));

        return services;
    }
}
