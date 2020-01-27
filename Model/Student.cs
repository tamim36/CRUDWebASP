using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PrimaryId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
