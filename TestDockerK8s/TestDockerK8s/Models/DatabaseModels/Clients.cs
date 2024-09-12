using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TestDockerK8s.Models.DatabaseModels
{
    public class Clients
    {
        public ObjectId Id { get; set; }
        [BsonElement("clientName")]
        public String ClientName { get; set; }

    }
}
