using MongoDB.Bson.Serialization.Attributes;
using System;

namespace biddermanagement.Entity
{
    public class Player
    {
        [BsonId]
        public Guid Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("natioanlity")]
        public string Natioanlity { get; set; }

        [BsonElement("speciality")]
        public string Speciality { get; set; }
    }
}
