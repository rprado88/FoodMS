using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodCore.Contracts;
using Cassandra;
using System.Text;
using Newtonsoft.Json;

namespace FoodCore.Data.DataManagement
{
    public class OrderDataManager : IOrderDataManager
    {
        public OrderDataManager()
        {
            
        }

        public async Task Create(Order order)
        {
            
            try
            {
                var cluster = Cluster.Builder()
                    .AddContactPoint("127.0.0.1")
                    .Build();

                var session = cluster.Connect("fooddb");

                StringBuilder cql = new StringBuilder();
                cql.Append("INSERT INTO orders (orderid, customerid, orderstatus, data) ");
                cql.Append("values ('");
                cql.Append(Guid.NewGuid());
                cql.Append("','");
                cql.Append(order.CustomerId);
                //cql.Append("','");
                //cql.Append(DateTime.Today.ToShortDateString());
                cql.Append("',");
                cql.Append((int)order.OrderStatus);
                cql.Append(",'");
                cql.Append(JsonConvert.SerializeObject(order));
                cql.Append("')");

                session.Execute(cql.ToString());

                await Task.CompletedTask;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Task<Order> Get(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrdersList(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
