using Factory_Method;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        List<IFactory> factories = new List<IFactory>
        {
            new AirWizzardFactory(),
            new WaterWizzardFactory(),
            new FireWizzardFactory(),
            new EarthWizzardFactory()
        };

        Wizzard wizzard = null ;
        while (true)
        {
         
            Random rand = new Random();

            int selectedWizzard = rand.Next(0, factories.Count);

            wizzard = factories[selectedWizzard].Create();

            Thread.Sleep(500);

            //if(selectedWizzard == 1)
            //{
            //    wizzard = factories[0].Create();
            //}
            //else if (selectedWizzard == 2)
            //{
            //    wizzard = factories[1].Create();
            //}

            Console.WriteLine(wizzard?.Info());
                
        }

    }
}
