
using ClsApi.Application.Usecases.Commands;
using FluentValidation;
using MediatR;

namespace ClsApi.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateEmployeeCommandHandler).Assembly);
            
            services.AddValidatorsFromAssembly(typeof(CreateEmployeeCommandHandler).Assembly);

            return services;
        }
    }
}