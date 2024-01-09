using Microsoft.AspNetCore.Identity;
using PROIECT.Helpers.Seeders;
using PROIECT.Models;

namespace PROIECT.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<UserManager<User>>();
            services.AddScoped<RoleManager<IdentityRole<Guid>>>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<UserSeeder>();
            services.AddTransient<RoleSeeder>();
            services.AddTransient<UserRoleSeeder>();

            return services;
        }
    }
}
