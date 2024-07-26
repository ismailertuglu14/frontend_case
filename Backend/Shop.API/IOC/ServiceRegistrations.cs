using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Shop.Repository.Repository.Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();
        }
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
