using MongoDB.Bson;
using MongoDB.Driver;

namespace Bootcamp601.Services
{
    public class MongoDBConnection
    {
        private IMongoDatabase _database;
        public MongoDBConnection()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("Bootcamp601CustomerDb"); //veri tabanı adı
        }

        public IMongoCollection<BsonDocument> GetCustomerCollection()
        {
            return _database.GetCollection<BsonDocument>("Customers"); // yukarıda oluşturduğumuz veri tabanı içindeki collection(Tablo) adı
        }
    }
}
