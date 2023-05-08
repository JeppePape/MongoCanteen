﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CanteenDB.Models
{
    public class Staff
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int  Salary { get; set; }
        public string CanteenName { get; set; }
    }
}
