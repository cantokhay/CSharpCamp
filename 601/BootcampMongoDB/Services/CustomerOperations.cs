using BootcampMongoDB.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

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

        public List<Customer> GetAllCustomersList()
        {
            var conn = new MongoDBConnection();
            var customerCollection = conn.GetCustomerCollection();
            var customers = customerCollection.Find(new BsonDocument()).ToList();
            List<Customer> customerList = new List<Customer>();
            foreach (var c in customers) {
                customerList.Add(new Customer
                {
                    CustomerId = c["_id"].ToString(),
                    CustomerFirstName = c["CustomerFirstName"].ToString(),
                    CustomerLastName = c["CustomerLastName"].ToString(),
                    CustomerCity = c["CustomerCity"].ToString(),
                    CustomerBalance = decimal.Parse(c["CustomerBalance"].ToString()),
                    CustomerTotal = int.Parse(c["CustomerTotal"].ToString())
                });
            }
            return customerList;
        }

        public void DeleteCustomer(string id)
        {
            var conn = new MongoDBConnection();
            var customerCollection = conn.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            customerCollection.DeleteOne(filter);
        }

        public void UpdateCustomer(Customer customer)
        {
            var conn = new MongoDBConnection();
            var customerCollection = conn.GetCustomerCollection();
            var filterById = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
            var updatedValue = Builders<BsonDocument>.Update
                .Set("CustomerFirstName", customer.CustomerFirstName)
                .Set("CustomerLastName", customer.CustomerLastName)
                .Set("CustomerCity", customer.CustomerCity)
                .Set("CustomerBalance", customer.CustomerBalance)
                .Set("CustomerTotal", customer.CustomerTotal);
            customerCollection.UpdateOne(filterById, updatedValue);
        }

        public Customer GetCustomerById(string id)
        {
            var conn = new MongoDBConnection();
            var customerCollection = conn.GetCustomerCollection();
            var filterById = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var resultCustomer = customerCollection.Find(filterById).FirstOrDefault();
            return new Customer
            {
                CustomerId = id,
                CustomerFirstName = resultCustomer["CustomerFirstName"].ToString(),
                CustomerLastName = resultCustomer["CustomerLastName"].ToString(),
                CustomerCity = resultCustomer["CustomerCity"].ToString(),
                CustomerBalance = decimal.Parse(resultCustomer["CustomerBalance"].ToString()),
                CustomerTotal = int.Parse(resultCustomer["CustomerTotal"].ToString())
            };
        }
    }
}
