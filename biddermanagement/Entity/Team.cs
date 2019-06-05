using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biddermanagement.Entity
{
    public class Team
    {
        public Team()
        {
            Players = new List<Player>();
        }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("noOfPlayers")]
        public int NoOfPlayers { get; set; }

        [BsonElement("score")]
        public float Score { get; set; }

        [BsonElement("players")]
        public List<Player> Players { get; set; }
    }
}
