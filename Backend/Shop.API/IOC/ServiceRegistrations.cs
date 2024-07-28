using Microsoft.EntityFrameworkCore;
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
            RegisterRepositories(services);
            RegisterServices(services);
            RegisterConfigs(services, configuration);
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Shop.Repository.Repository.Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartItemRepository, CartItemRepository>();
        }
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<TokenService>();
        }
        public static void RegisterConfigs(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.Configure<JwtDto>(configuration.GetSection("JWT"));
        }
    }
}
