using HabitTracker.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HabitTracker.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //Manual Way
            //services.AddTransient<IService, Service>();

            services.Scan(scan => scan
                .FromAssemblyOf<IApplicationService>()
                .AddClasses(classes => classes.InNamespaces("HabitTracker.Application.Services.TransientServices"))
                .AsImplementedInterfaces()
                .WithTransientLifetime());

            services.Scan(scan => scan
                .FromAssemblyOf<IApplicationService>()
                .AddClasses(classes => classes.InNamespaces("HabitTracker.Application.Services.ScopedServices"))
                .AsImplementedInterfaces()
                .WithScopedLifetime());

            services.Scan(scan => scan
                .FromAssemblyOf<IApplicationService>()
                .AddClasses(classes => classes.InNamespaces("HabitTracker.Application.Services.SingletonServices"))
                .AsImplementedInterfaces()
                .WithSingletonLifetime());


            return services;
        }
    }
}