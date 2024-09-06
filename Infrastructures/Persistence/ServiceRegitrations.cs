using Application.Repositories;
using Application.Repositories.Reads;
using Application.Repositories.Writes;
using Application.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;
using Persistence.Repositories.Reads;
using Persistence.Repositories.Writes;
using Persistence.UnitOfWorks;

namespace Persistence;

public static class ServiceRegitrations
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfigurationManager configuration)
    {
        services.AddDbContext<AppDbContext>(op => op.UseSqlServer(configuration.GetConnectionString("default")));

        // Reads
        services.AddScoped<ICarReadrepository, CarReadRepository>();
        services.AddScoped<IUserReadRepository, UserReadRepository>();
        services.AddScoped<IGalleryReadRepository, GalleryReadRepository>();

        // Writes
        services.AddScoped<ICarWriteRepository, CarWriteRepository>();
        services.AddScoped<IUserWriteRepository, UserWriteRepository>();
        services.AddScoped<IGalleryWriteRepository, GalleryWriteRepository>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
