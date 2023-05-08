using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CanteenDB.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? AUID { get; set; }
    }

}