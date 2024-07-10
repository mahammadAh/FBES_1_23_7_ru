using FirstConnection;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

public class Program
{
    public static void Main(string[] args)
    {

        Repository myRepository = new Repository();


        //myRepository.SelectFromDb();

        //myRepository.InsertToDb();

        //myRepository.SelectFromDb();

        myRepository.ExecProcInDb();
    }
}
