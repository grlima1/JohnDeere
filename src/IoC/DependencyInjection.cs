using Infra;
using Microsoft.Extensions.DependencyInjection;
using Presentation;

namespace IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Register your services here
            // Example: services.AddScoped<IMyService, MyService>();

            // Registering the Comments API
            services.AddTransient<ICommentsApi, CommentsApi>();

            // Registering the Presentation layer
            services.AddTransient<IPresentation, ConsolePresentation>();

            return services;
        }
    }
}
