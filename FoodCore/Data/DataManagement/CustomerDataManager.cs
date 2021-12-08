using System;
using System.Threading.Tasks;
using FoodCore.Contracts;
using Cassandra;
using System.Text;
using Newtonsoft.Json;

namespace FoodCore.Data.DataManagement
{
    public class CustomerDataManager : ICustomerDataManager
    {
        public CustomerDataManager()
        {
        }

        public async Task<string> Create(Account account)
        {
           try
            {
               var cluster = Cluster.Builder()
                    .AddContactPoint("127.0.0.1")
                    .Build();

                var session = cluster.Connect("fooddb");

                StringBuilder cql = new StringBuilder();
                cql.Append("INSERT INTO account (customerid, customerinfo) ");
                cql.Append("values ('");
                cql.Append(account.CustomerId);
                cql.Append("','");
                cql.Append(JsonConvert.SerializeObject(account));
                cql.Append("')");

                session.Execute(cql.ToString());

                if (Task.CompletedTask.IsCompleted)
                {
                    return account.CustomerId;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return string.Empty;
        }

        public async Task<Account> Get(string customerId)
        {
            Account result = new Account();
            try
            {
                var cluster = Cluster.Builder()
                        .AddContactPoint("127.0.0.1")
                        .Build();

                var session = cluster.Connect("fooddb");

                StringBuilder cql = new StringBuilder();

                cql.Append("SELECT * from account where customerid = '");
                cql.Append(customerId);
                cql.Append("'");
                

                var cassandraResult = session.Execute(cql.ToString());

                if (cassandraResult != null)
                {
                    foreach (var item in cassandraResult)
                    {
                        var customerInfo = item.GetValue<string>("customerinfo");

                        var account = JsonConvert.DeserializeObject<Account>(customerInfo);

                        result = account;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public async Task<bool> Delete(string customerId)
        {
            bool result = false;
            try
            {
                var cluster = Cluster.Builder()
                    .AddContactPoint("127.0.0.1")
                    .Build();

                var session = cluster.Connect("fooddb");

                StringBuilder cql = new StringBuilder();

                cql.Append("delete from account where customerid = '");
                cql.Append(customerId);
                cql.Append("' IF EXISTS");
                
                var cassandraResult = session.Execute(cql.ToString());

                if (cassandraResult != null)
                {
                    foreach (var item in cassandraResult)
                    {
                        result = item.GetValue<bool>(0);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public async Task<bool> Update(Account account)
        {
            bool result = false;
            try
            {
                var cluster = Cluster.Builder()
                    .AddContactPoint("127.0.0.1")
                    .Build();

                var session = cluster.Connect("fooddb");

                StringBuilder cql = new StringBuilder();
                cql.Append("UPDATE account set ");
                cql.Append("customerinfo ='");
                cql.Append(JsonConvert.SerializeObject(account));
                cql.Append("' WHERE customerId = '");
                cql.Append(account.CustomerId);
                cql.Append("' IF EXISTS");
                    
                var cassandraResult = session.Execute(cql.ToString());

                if (cassandraResult != null)
                {
                    foreach (var item in cassandraResult)
                    {
                        result = item.GetValue<bool>(0);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
