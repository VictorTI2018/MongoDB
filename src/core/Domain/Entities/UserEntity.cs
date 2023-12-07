using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        [BsonElement("name")]
        public string Name { get; private set; }

        [BsonElement("email")]
        public string Email { get; private set; }

        [BsonElement("password")]
        public string Password { get; private set; }

        public UserEntity(string name,
            string email,
            string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
