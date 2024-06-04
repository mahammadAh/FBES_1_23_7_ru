using System;
using System.Collections;



public interface IClient
{
   public string Name { get; set; }
   
   public List<string> Basket { get; set; }

    public void GetMessage(string message);
}


public class PersonClient : IClient
{
    public string Name { get ; set ; }
    public List<string> Basket { get; set; } = new List<string>();

    public int Age { get; set; }

    public void GetMessage(string message)
    {
        Console.WriteLine(message);
    }
}


public class CompanyClient : IClient
{
    public string Name { get; set; }
    public List<string> Basket { get; set; } = new List<string>();

    public int VOEN { get; set; }
    public void GetMessage(string message)
    {
        Console.WriteLine(message);
    }

}





public class Shop 
{ 
    public string Name { get; set; }

    public List<string> Products { get; set; }

    public List<IClient> Clients { get; set; }

    public Shop()
    {
        Clients = new List<IClient>();
        Products = new List<string>();
    }

    public void AddProduct(string productName)
    {
        Products.Add(productName);

        foreach(var client in Clients)
        {
            var result = client.Basket.FirstOrDefault(c => c ==  productName);

            if (!string.IsNullOrEmpty(result))
            {
                client.GetMessage($"Dear {client.Name} you can buy {productName}");
            }
        }
    }

    public void Subscribe(IClient client)
    {
        Clients.Add(client);
    }
}






public class Program
{
    public static void Main(string[] args)
    {

        Shop StepShop = new Shop();

        PersonClient Anvar = new PersonClient
        {
            Name = "Anvar"
        };

        Anvar.Basket.Add("Iphone 15");
        Anvar.Basket.Add("Bed");

        StepShop.Subscribe(Anvar);

        CompanyClient DavidMMC = new CompanyClient
        {
            Name = "DavidMMC"
        };

        DavidMMC.Basket.Add("sofa");
        DavidMMC.Basket.Add("table");

        StepShop.Subscribe(DavidMMC);


        while (true)
        {
            StepShop.AddProduct(Console.ReadLine());
        }
    }
}


