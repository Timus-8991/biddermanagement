using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace biddermanagement.Entity
{
    public class Bidder
    {
        public Bidder()
        {
            Teams = new List<Team>();
        }

        [BsonId]
        public Guid Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("role")]
        public string Role { get; set; }

        [BsonElement("teams")]
        public List<Team> Teams { get; set; }
    }
}
