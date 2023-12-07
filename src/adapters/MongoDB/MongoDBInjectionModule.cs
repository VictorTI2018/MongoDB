using Domain.Interfaces.Repository;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Repositories;

namespace MongoDB
{
    public static class MongoDBInjectionModule
    {
        public static void AddRepositoryModule(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
