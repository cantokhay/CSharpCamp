using BootcampMongoDB.Entities;
using MongoDB.Bson;

namespace BootcampMongoDB.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            var conn = new MongoDBConnection();
            var customerCollection = conn.GetCustomerCollection();

            var document = new BsonDocument //sütun adları ve değerleri
            {
                { "CustomerFirstName", customer.CustomerFirstName },
                { "CustomerLastName", customer.CustomerLastName },
                { "CustomerCity", customer.CustomerCity },
                { "CustomerBalance", customer.CustomerBalance },
                { "CustomerTotal", customer.CustomerTotal }
            };

            customerCollection.InsertOne(document);
        }
    }
}
