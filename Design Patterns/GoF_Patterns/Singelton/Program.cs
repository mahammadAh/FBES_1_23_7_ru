public class DbConnection
{
    string ConnectionString { get; set; }

    private static DbConnection instance;

    public static DbConnection Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new DbConnection();

            }
            return instance;
        }
    }

    private DbConnection()
    {
        this.ConnectionString = "db connection";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //var connection1 = new DbConnection();
        var connection1 = DbConnection.Instance;

       //var connection1 = new DbConnection();
        var connection2 = DbConnection.Instance;

        //var connection1 = new DbConnection();
        var connection3 = DbConnection.Instance;
    }
}