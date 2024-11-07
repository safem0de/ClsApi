
using ClsApi.Application.Interfaces.IServices;
using ClsApi.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClsApi.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationDI(this IServiceCollection services)
    {
        return services.AddScoped<IEmployeeService, EmployeeService>();
    }
}

