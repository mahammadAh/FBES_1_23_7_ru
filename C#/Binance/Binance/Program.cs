using System.Xml.Linq;

public class Coin
{
    public string Name { get; set; }

    public int Price { get; set; }
}

public class Wallet
{ 
    private List<Coin> Coins { get; set;}

    public Wallet ()
    {
        Coins = new List<Coin> ();
    }

    public void AddCoins(ref Coin coin , int count)
    {
        for(int i = 0; i < count; i++)
        {
            Coins.Add(coin);
        }
    }
    public List<Coin> getCoins()
    {
        return Coins;
    }

}

public class User
{
    public string Name { get; set; }

    public Wallet wallet { get; set; }

    private int minCoinPrice { get; set; }

   private int maxCoinPrice { get; set; }

    public User()
    {
        wallet = new Wallet ();
    }

    
    public void SetMinAndMaxCoinPrice(int minCoinPrice, int maxCoinPrice)
    {
        this.minCoinPrice = minCoinPrice; 
        this.maxCoinPrice = maxCoinPrice;
    }

    public void selCoins(Coin coin)
    {
        if(coin.Price <= minCoinPrice || coin.Price >= maxCoinPrice)
        {
            Console.WriteLine($"{Name} sold {wallet.getCoins().Count} coins for {coin.Price} $");
        }
    }


}
public static class Binance
{
   public static List<User> Users { get; set; }



    public static event Action<Coin> changePriceEvent;

    static Binance()
    {
        Users = new List<User> ();
    }



    public static void ChangeCoinPrice(ref Coin coin)
    {
        Random random = new Random();
        int CoinPriceChange = random.Next(-10, 10);

        coin.Price += CoinPriceChange;
        Console.WriteLine($"Current coin price {coin.Price}");
        changePriceEvent(coin);


    }


}




public class Program
{
    public static void Main(string[] args)
    {
        Binance.Users.Add(new User() { Name = "David" });
        Binance.Users.Add(new User() { Name = "Alyona" });
        Binance.Users.Add(new User() { Name = "Fuad" });


        Coin XRP = new Coin() { Name = "XRP", Price = 250 };

        Binance.Users[0].wallet.AddCoins(ref XRP, 87);
        Binance.Users[1].wallet.AddCoins(ref XRP, 39);
        Binance.Users[2].wallet.AddCoins(ref XRP, 19);

        Binance.Users[0].SetMinAndMaxCoinPrice(240,260);
        Binance.Users[1].SetMinAndMaxCoinPrice(243, 272);
        Binance.Users[2].SetMinAndMaxCoinPrice(245, 255);


        Binance.changePriceEvent += Binance.Users[0].selCoins;
        Binance.changePriceEvent += Binance.Users[1].selCoins;
        Binance.changePriceEvent += Binance.Users[2].selCoins;

        while (true)
        {
            Thread.Sleep(1000);
            Binance.ChangeCoinPrice(ref XRP);
        }
    }
}