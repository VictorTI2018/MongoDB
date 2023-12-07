using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Services.User;

namespace Services
{
    public static class ServiceInjectionModule
    {
        public static void AddServiceModule(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
