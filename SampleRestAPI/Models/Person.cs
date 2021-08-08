using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SampleRestAPI.Models
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }

        public string Name { get; set; }

    }
}
