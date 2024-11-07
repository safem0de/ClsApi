

using ClsApi.Domain.Interfaces.Respositories;
using Microsoft.Extensions.DependencyInjection;

namespace ClsApi.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationDI(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        return services;
    }
}

