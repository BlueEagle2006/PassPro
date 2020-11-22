using System;
// mongodb
using MongoDB.Bson.Serialization.Attributes;

namespace PassPro1
{
    public class Detail
    {
        [BsonId]
        public Guid Id { get; set; }
        public string User { get; set; }
        public string Web { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
