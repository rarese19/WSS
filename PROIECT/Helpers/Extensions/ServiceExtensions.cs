using Microsoft.AspNetCore.Identity;
using PROIECT.Helpers.Seeders;
using PROIECT.Models;
using WSS.Repositories.AngajatRepository;
using WSS.Repositories.MagazinProdusRepository;
using WSS.Repositories.MagazinRepository;
using WSS.Repositories.PartieRepository;
using WSS.Repositories.ProdusRepository;
using WSS.Repositories.StatiuneRepository;
using WSS.Repositories.UserProdusRepository;
using WSS.Repositories.UserRepository;
using WSS.Services.AngajatServices;
using WSS.Services.MagazinProdusServices;
using WSS.Services.MagazinServices;
using WSS.Services.PartieServices;
using WSS.Services.ProdusServices;
using WSS.Services.StatiuneServices;
using WSS.Services.UserProdusServices;
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
            services.AddTransient<IAngajatRepository, AngajatRepository>();
            services.AddTransient<IProdusRepository, ProdusRepository>();
            services.AddTransient<IMagazinProdusRepository, MagazinProdusRepository>();
            services.AddTransient<IUserProdusRepository, UserProdusRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserServices, UserServices>();
            services.AddTransient<IMagazinServices,  MagazinServices>();
            services.AddTransient<IStatiuneServices, StatiuneServices>();
            services.AddTransient<IPartieServices, PartieServices>();
            services.AddTransient<IAngajatServices, AngajatServices>();
            services.AddTransient<IProdusServices, ProdusServices>();
            services.AddTransient<IMagazinProdusService, MagazinProdusService>();
            services.AddTransient<IUserProdusServices, UserProdusServices>();

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
