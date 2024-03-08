
using MeuProjeto.Application.Services;
using Gladiatus.Application.Interface;

namespace Gladiatus.Application
{
    public static class Setup
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IUserApiService, UserApiService>();
            return services;
        }
    }
}