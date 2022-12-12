using LiteDB;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleRepository.Lite
{
    public static class Extensions
    {
        public static IServiceCollection AddLiteRepository(this IServiceCollection services, IConfiguration config, string section)
        {
            services.Configure<LiteRepositoryOptions>(config.GetSection(section));
            services.AddTransient<IRepository, LiteRepository>();
            return services;
        }
    }
}
