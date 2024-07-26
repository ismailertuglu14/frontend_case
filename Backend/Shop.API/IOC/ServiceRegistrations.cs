using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shop.Core.DTOs;
using Shop.Core.Utils;
using Shop.Repository;
using Shop.Repository.IRepository;
using Shop.Repository.Repository;
using Shop.Services.IServices;
using Shop.Services.Services;

namespace Shop.Core.IOC
{
    public static class ServiceRegistrations
    {
        public static void Register(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            RegisterRepositories(services);
            RegisterServices(services);
            RegisterConfigs(services, configuration);
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Shop.Repository.Repository.Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();
        }
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<TokenService>();
        }
        public static void RegisterConfigs(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtDto>(configuration.GetSection("JWT"));
        }
    }
}
