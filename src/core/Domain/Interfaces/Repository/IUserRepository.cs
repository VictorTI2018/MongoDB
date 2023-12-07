using Domain.Entities;

namespace Domain.Interfaces.Repository
{
    public interface IUserRepository : IMongoDBRepository<UserEntity>
    {
    }
}
