using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bootcamp601.Entities
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerId { get; set; } //MongoDB keeps the _id field as a string
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerCity { get; set; }
        public decimal CustomerBalance { get; set; }
        public int CustomerTotal { get; set; }
    }
}
