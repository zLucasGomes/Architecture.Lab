using FluentValidation;

namespace DDD.Configurations;

public static class Controller
{
    public static IServiceCollection ConfigureController(this IServiceCollection services)
    {
        ValidatorOptions.Global.DefaultClassLevelCascadeMode = CascadeMode.Stop;

        return services;
    }
}
