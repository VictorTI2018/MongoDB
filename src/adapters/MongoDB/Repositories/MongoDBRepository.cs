using Domain.Entities;
using Domain.Interfaces.Repository;
using MongoDB.Driver;
using MongoDB.Settings;
using System.Linq.Expressions;

namespace MongoDB.Repositories
{
    public class MongoDBRepository<T> : IMongoDBRepository<T>
        where T : BaseEntity
    {
        private readonly IMongoCollection<T> _model;

        public MongoDBRepository(MongoDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _model = database.GetCollection<T>(typeof(T).Name.ToLower());
        }

        public async Task<List<T>> GetAsync()
            => await _model.Find(_ => true).ToListAsync();

        public async Task<T> GetOneAsync(Expression<Func<T, bool>> expression)
            => await _model.Find(expression).FirstOrDefaultAsync();

        public async Task<T> AddAsync(T entity)
        {
            await _model.InsertOneAsync(entity);
            return entity;
        }
    }
}
