using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ZenBlog.Application.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceRegistrations).Assembly);
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(typeof(ServiceRegistrations).Assembly);
            });

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}