using Dapper;
using DapperCarCenter.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;


namespace DapperCarCenter
{
    public class CarRepository
    {
        public string ConnectionString { get; set; }

        public CarRepository() {
             ConnectionString = ConfigurationManager.ConnectionStrings["localAutoCenterDb"].ConnectionString;
        }

        public void Add(Car car)
        {
            using(SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                string query = @"INSERT INTO Car VALUES(@Model,@Color,@Year)";
               
                con.Execute(query, car);
            }
        }

        public List<Car> GetAll()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                string query = "SELECT * FROM Car";

               var result = con.Query<Car>(query);

               return result.ToList();
            }
        }
    }
}
