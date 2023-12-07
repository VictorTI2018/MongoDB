using Domain.Entities;
using Domain.Interfaces.Repository;
using MongoDB.Settings;

namespace MongoDB.Repositories
{
    public class UserRepository(MongoDBSettings settings) : MongoDBRepository<UserEntity>(settings) , IUserRepository
    {
    }
}
