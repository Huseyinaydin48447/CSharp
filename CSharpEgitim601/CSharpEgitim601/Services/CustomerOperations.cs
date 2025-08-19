using CSharpEgitim601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitim601.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();


            var document = new BsonDocument
      {
        { "CustomerName",customer.CustomerName},
        {"CustomerSurname",customer.CustomerSurname },
        {"CustomerCity",customer.CustomerCity },
        {"CustomerBalance",customer.CustomerBalance },
        {"CustomerShoppingCount",customer.CustomerShoppingCount }
      };

            customerCollection.InsertOne(document);

        }
        public List<Customer> GetAllCustomer()
        {
            var conn = new MongoDbConnection();
            var customerCollection = conn.GetCustomerCollection();
            var customers = customerCollection.Find(new BsonDocument()).ToList();
            List<Customer> customerList = new List<Customer>();
            foreach (var x in customers)
            {
                customerList.Add(new Customer
                {
                    CustomerID = x["_id"].ToString(),
                    CustomerBalance = decimal.Parse(x["CustomerBalance"].ToString()),
                    CustomerCity = x["CustomerCity"].ToString(),
                    CustomerName = x["CustomerName"].ToString(),
                    CustomerShoppingCount = int.Parse(x["CustomerShoppingCount"].ToString()),
                    CustomerSurname = x["CustomerSurname"].ToString()
                });
            }
            return customerList;
        }
        public void DeleteCustomer(string id)
        {
            var conn = new MongoDbConnection();
            var customerCollection = conn.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            customerCollection.DeleteOne(filter);
        }
        public void UpdateCustomer(Customer customer)
        {
            var conn = new MongoDbConnection();
            var customerCollection = conn.GetCustomerCollection();
            var filters = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerID));
            var updatededValue = Builders<BsonDocument>.Update
              .Set("CustomerName", customer.CustomerName)
              .Set("CustomerSurname", customer.CustomerSurname)
              .Set("CustomerCity", customer.CustomerCity)
              .Set("CustomerBalance", customer.CustomerBalance)
              .Set("CustomerShoppingCount", customer.CustomerShoppingCount);
            customerCollection.UpdateOne(filters, updatededValue);
        }

        public Customer GetCustomerById(string id)
        {
            var conn = new MongoDbConnection();
            var customerCollection = conn.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var result = customerCollection.Find(filter).FirstOrDefault();
            return new Customer
            {
                CustomerBalance = decimal.Parse(result["CustomerBalance"].ToString()),
                CustomerCity = result["CustomerCity"].ToString(),
                CustomerName = result["CustomerName"].ToString(),
                CustomerSurname = result["CustomerSurname"].ToString(),
                CustomerShoppingCount = int.Parse(result["CustomerShoppingCount"].ToString()),
                CustomerID = id


            };
        }




    }
}
