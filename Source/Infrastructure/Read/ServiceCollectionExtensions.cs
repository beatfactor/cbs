using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Read
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddReadModule(this IServiceCollection services)
        {
            services.AddTransient<IReadModule>();
            return services;
        }
    }
}