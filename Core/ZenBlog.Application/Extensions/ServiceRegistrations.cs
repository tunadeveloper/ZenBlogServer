using Microsoft.Extensions.DependencyInjection;

namespace ZenBlog.Application.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceRegistrations).Assembly);
        }
    }
}
