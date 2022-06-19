using epic.Services.Implementations;
using epic.Services.Interfaces;

namespace epic.APIs.Configuration
{
    public static class ConfigureDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}
