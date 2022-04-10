using FakeStore.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FakeStore.Data
{
    //this class performs all CRUD operations
    internal class CostumerDAO
    {
        private string _connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=FakeStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<CostumerModel> FetchAllCostumers()
        {
            var costumerList = new List<CostumerModel>();

            //start connection with database
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.Costumers";
                SqlCommand command =  new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var costumer = new CostumerModel();
                        costumer.CostumerId = reader.GetInt32(0);
                        costumer.FirstName = reader.GetString(1);
                        costumer.LastName = reader.GetString(2);   
                        costumer.costumerSince = reader.
                    }
                }
            }

                return costumerList;
        }
    }
}