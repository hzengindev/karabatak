using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Domain
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDomainDependencies(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //services.AddFluentValidation(z =>
            //    {
            //        z.DisableDataAnnotationsValidation = true;
            //        z.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //    });

            return services;
        }
    }
}
