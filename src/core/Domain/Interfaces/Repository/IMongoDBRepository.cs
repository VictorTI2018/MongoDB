using Domain.Entities;
using System.Linq.Expressions;

namespace Domain.Interfaces.Repository
{
    public interface IMongoDBRepository<T>
        where T : BaseEntity
    {
        Task<List<T>> GetAsync();

        Task<T> AddAsync(T entity);

        Task<T> GetOneAsync(Expression<Func<T, bool>> expression);
    }
}
