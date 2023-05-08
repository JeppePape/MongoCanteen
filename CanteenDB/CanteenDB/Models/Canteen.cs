using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CanteenDB.Models
{
    internal class Canteen
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? CanteenName { get; set; }

        public float AvgRating { get; set; }

        public decimal Price { get; set; }

        public string PostCode { get; set; }

        public string Author { get; set; } = null!;

    }
}
