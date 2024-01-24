using Microsoft.AspNetCore.Identity;
using PROIECT.Helpers.Seeders;
using PROIECT.Models;
using WSS.Repositories.MagazinRepository;
using WSS.Repositories.PartieRepository;
using WSS.Repositories.StatiuneRepository;
using WSS.Repositories.UserRepository;
using WSS.Services.MagazinServices;
using WSS.Services.PartieServices;
using WSS.Services.StatiuneServices;
using WSS.Services.UserServices;

namespace PROIECT.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<UserManager<User>>();
            services.AddScoped<RoleManager<IdentityRole<Guid>>>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IMagazinRepository, MagazinRepository>();
            services.AddTransient<IStatiuneRepository, StatiuneRepository>();
            services.AddTransient<IPartieRepository, PartieRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserServices, UserServices>();
            services.AddTransient<IMagazinServices,  MagazinServices>();
            services.AddTransient<IStatiuneServices, StatiuneServices>();
            services.AddTransient<IPartieServices, PartieServices>();
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
