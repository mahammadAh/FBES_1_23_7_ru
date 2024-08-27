public class Program
{
    public static void Main(string[] args)
    {

        //PrintDataAsync();

        //Loop();

        string dbQueryResult = null;

       // var task = Task.Run(GetDataFromDB1);

        dbQueryResult = GetDataFromDbAsync().Result;

        Console.WriteLine(dbQueryResult);


    }




    public async static void PrintDataAsync()
    {
        Console.WriteLine("Start Async Function");
        var result1 = await PrintNumber();
        Console.WriteLine(result1);
        
        var result2 = await PrintNumber();
        Console.WriteLine(result2);
        Console.WriteLine("End Async Function");
    }

    public static Task<int> PrintNumber()
    {

        Task<int> task = Task.Run
            (() =>
            {
                Thread.Sleep(2000);
                return 42;
            });

        return task;
    }


    public static string GetDataFromDB1()
    {
        Thread.Sleep(5000);
        return "10000 rows";
    }

    public async static Task<string> GetDataFromDbAsync()
    {
        var result = await GetDataFromDB2();
        return result;
    }

    public static Task<string> GetDataFromDB2()
    {
        Thread.Sleep(5000);

        Task<string> task = Task.Run
          (() =>
          {
              Thread.Sleep(2000);
              return "10000 rows";
          });

        return task;
  
    }



    public static void Loop()
    {
        for(int i=1; i<1000;i++)
        {
            Thread.Sleep(300);
            Console.WriteLine(i);
        }
    }
}