using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConnection
{
    public class Repository
    {
        public string ConnectionString { get; set; }

        public SqlConnection myConnection { get; set; }

        public Repository() {

            ConnectionString = ConfigurationManager.ConnectionStrings["localDbConnection"].ConnectionString;

            myConnection = new SqlConnection(ConnectionString);
        }



        public void SelectFromDb()
        {
            SqlCommand cmd = null;


            try
            {
                myConnection.Open();

                string sqlQuery = "SELECT * FROM Authors";

                //string sqlQuery = "SELECT * FROM Authors ; SELECT * FROM Books";

                cmd = new SqlCommand(sqlQuery, myConnection);

                //cmd.CommandText = sqlQuery;

                //cmd.Connection = conn;

                SqlDataReader queryResult = cmd.ExecuteReader();

                do
                {
                    while (queryResult.Read())
                    {
                        Console.WriteLine(queryResult[0].ToString() + " " + queryResult[1].ToString() + " " + queryResult[2].ToString());
                        //Console.WriteLine(queryResult["Id"].ToString() + " " + queryResult["Name"].ToString() + " " + queryResult["Surname"].ToString());
                    }
                }
                while (queryResult.NextResult());

            }
            finally
            {
                if (myConnection != null)
                {
                    myConnection.Close();
                }
            }
        }


        public void InsertToDb()
        {
            try
            {
                myConnection.Open();

                //string name = "'Artur'";
                //string surname ="'Klark'); drop table Books ; drop table Authors; --";


                //string myCommnad = $"INSERT INTO Authors VALUES({name},{surname})";
                ////string myCommnad = "INSERT INTO Authors VALUES('"+name+"','"+surname+"')";


                string name = "'Artur'";
                string surname = "'Klark');drop table Authors; --";


                string myCommnad = @"INSERT INTO Authors VALUES(@name,@surname)";
            
                SqlCommand cmd = new SqlCommand(myCommnad, myConnection);

                //SqlParameter sqlParm1 = new SqlParameter();
                //sqlParm1.ParameterName = "name";
                //sqlParm1.SqlDbType = SqlDbType.VarChar;
                //sqlParm1.Value = name;

                //cmd.Parameters.Add(sqlParm1);

                cmd.Parameters.Add(new SqlParameter("name", name));
                cmd.Parameters.Add(new SqlParameter("surname", surname));

                var result = cmd.ExecuteNonQuery();

                Console.WriteLine(result);

            }
            finally
            {
                if(myConnection!=null)
                { 
                    myConnection.Close(); 
                }

            }
        }


        public void ExecProcInDb()
        {
            try
            {
                myConnection.Open();

                string query = "getPageCount";
                SqlCommand cmd = new SqlCommand(query, myConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@BookName", "Voyna i Mir"));

                SqlParameter outputParametr = new SqlParameter();

                outputParametr.ParameterName = "@PageCount";
                outputParametr.DbType = DbType.Int32;
                outputParametr.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParametr);

                cmd.ExecuteNonQuery();

                Console.WriteLine(cmd.Parameters["@PageCount"].Value.ToString());

            }

            finally
            {
                if (myConnection != null)
                    myConnection.Close();
            }
        }
    }
}
