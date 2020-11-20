using System;
using MongoDB.Bson.Serialization.Attributes;

namespace PassPro1
{
    class Class
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Web { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
