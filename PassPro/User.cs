using System;
// mongodb
using MongoDB.Bson.Serialization.Attributes;

namespace PassPro
{
    public class User
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
