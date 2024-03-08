
using Gladiatus.Core.Interfaces.Services;
using Gladiatus.Core.Repository;

namespace Gladiatus.Core
{
    public static class Setup
    {
        public static IServiceCollection AddCoreLayer(this IServiceCollection services)
        {

            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}