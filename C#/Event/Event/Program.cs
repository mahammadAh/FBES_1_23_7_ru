using System.Runtime.InteropServices;


public class Sock
{
    public int Size { get; set; }

    public string Print { get; set; }

    public int Price { get; set; }
}


//public interface ISockBuyer {
//    public void BuySock(eShop shop);
//}

public delegate void BuySock(eShop shop);

public class eShop
{
    public List<Sock> Socks { get; set; }

    // public List<ISockBuyer> Subscribes { get; set; }


    //private BuySock _buySock {get;set; }

    public event BuySock buyEvent;

    public eShop()
    {
        Socks = new List<Sock>();
        //Subscribes =  new List<ISockBuyer>();
    }

    //public void AddBuySock(BuySock BuySockDelegate)
    //{
    //    _buySock += BuySockDelegate;
    //}

    //public void RemoveBuySock(BuySock BuySockDelegate)
    //{
    //    _buySock -= BuySockDelegate;
    //}

    public void AddSocks(Sock sock)
    {
        Socks.Add(sock);

        buyEvent?.Invoke(this);
    }
}


public class Person  //: ISockBuyer
{
    public string Name { get; set; }

    public int Budget { get; set; }

    public void BuySock(eShop shop)
    {       
        for(int i=0; i<shop.Socks.Count; i++) {
            if (shop.Socks[i].Price <= Budget)
            {
                Console.WriteLine($"{Name} bought sock with {shop.Socks[i].Print} print");
                Budget -= shop.Socks[i].Price;
                shop.Socks.RemoveAt(i);
          
                return;
            }
        }
        Console.WriteLine($"{Name} can't buy Sock");
    }
}


public class Company //: ISockBuyer
{
    public string Name { get; set; }

    public int Budget { get; set; }

    public void BuySock(eShop shop)
    {
        for (int i = 0; i < shop.Socks.Count; i++)
        {
            if (shop.Socks[i].Price <= Budget)
            {
                Console.WriteLine($"{Name} bought sock with {shop.Socks[i].Print} print");
                Budget -= shop.Socks[i].Price;
                shop.Socks.RemoveAt(i);

                return;
            }
        }
        Console.WriteLine($"{Name} can't buy Sock");
    }

  
}





public class Program
{

    public static eShop myShop = new eShop();
    public static void Main(string[] args)
    {
 


        Person client1 = new Person() { Name = "Anvar", Budget =28 };
        Person client2 = new Person() { Name = "David", Budget = 10 };
        Person client3 = new Person() { Name = "Faxri", Budget = 13 };
        Person client4 = new Person() { Name = "Emil", Budget = 15 };


        //myShop.Subscribes.Add(client1);
        //myShop.Subscribes.Add(client2);
        //myShop.Subscribes.Add(client3);
        //myShop.Subscribes.Add(client4);

        //myShop._buySock += client1.BuySock;
        //myShop._buySock += client2.BuySock;
        //myShop._buySock += client3.BuySock;
        //myShop._buySock += client4.BuySock;

        //myShop.AddBuySock(client1.BuySock);
        //myShop.AddBuySock(client2.BuySock);
        //myShop.AddBuySock(client3.BuySock);
        //myShop.AddBuySock(client4.BuySock);

        myShop.buyEvent += client1.BuySock;
        myShop.buyEvent += client2.BuySock;
        myShop.buyEvent += client3.BuySock;
        myShop.buyEvent += client4.BuySock;

        Company client5 = new Company() { Name = "Novademy", Budget = 200 };

        //myShop.Subscribes.Add(client5);
        //myShop._buySock += client5.BuySock;
        //myShop.AddBuySock(client5.BuySock);
        // myShop._buySock = null;
        //myShop.AddBuySock(null);
        myShop.buyEvent += client5.BuySock;
        myShop.buyEvent += null;
        addSocks();

        //Random r = new Random();
        //int randomNumber = r.Next(10, 20);
        //while (true)
        //{
        //    Thread.Sleep(300);
        //    client1.BuySock(myShop);
        //    Thread.Sleep(300);
        //    client2.BuySock(myShop);
        //    Thread.Sleep(300);
        //    client3.BuySock(myShop);
        //    Thread.Sleep(300);
        //    client4.BuySock(myShop);

        //    randomNumber--;
        //    if (randomNumber == 0)
        //    {
        //        addSocks();
        //    }
        //}

    }

    public static void addSocks()
    {
        
        myShop.AddSocks(new Sock { Print = "Dinozavr", Price = 15, Size = 39 });      
        myShop.AddSocks(new Sock { Print = "Doner", Price = 12, Size = 41 });       
        myShop.AddSocks(new Sock { Print = "Panda", Price = 17, Size = 42 });      
        myShop.AddSocks(new Sock { Print = "C++", Price = 9, Size = 38 });    
        myShop.AddSocks(new Sock { Print = "Dollar", Price = 11, Size = 44 });
    }


}