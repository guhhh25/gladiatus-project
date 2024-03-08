using Gladiatus.Core.Interfaces.Repository;
using Gladiatus.Infrastructure.Repository.User;
using Microsoft.Extensions.DependencyInjection;

namespace Gladiatus.Infrastructure.Repository // O namespace é ajustado aqui
{
    public static class Setup
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddSqlServer<ApplicationDbContext>(connectionString);

            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}