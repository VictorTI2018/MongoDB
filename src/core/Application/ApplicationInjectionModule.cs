using Application.Presenters.User;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationInjectionModule
    {
        public static void AddPresenterModule(this IServiceCollection services)
        {
            services.AddScoped<IUserPresenter, UserPresenter>();
        }
    }
}
