using Facade;
using System.Text.Json;


public class Data 
{
    public DateTime dateTime { get; set; }
    public string text { get; set; }
}



public class Program
{
    public static void Main(string[] args)
    {
        List<Data> list = new List<Data>
        {
            new Data { dateTime = DateTime.Now,text = "Data 1" },
            new Data { dateTime = DateTime.Now,text = "Data 2" },
            new Data { dateTime = DateTime.Now,text = "Data 3" }
        };


        SaveToJsonFacade<List<Data>>.Save("myData", list);

    }
}