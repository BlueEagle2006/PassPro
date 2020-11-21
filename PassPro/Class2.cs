using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PassPro
{
    class UserCC
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
