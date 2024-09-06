using Application.Repositories;
using Application.Services;
using Application.UnitOfWorks;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure;

public static class ServiceRegistrations
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddMediatR(p => p.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        return services;
    }
}
