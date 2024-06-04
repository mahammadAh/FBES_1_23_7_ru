
public interface IRoute
{
    public string Navigate(string Longitute, string Latitude);
}


public class BicyleRouteStrategy : IRoute
{
    public string Navigate(string Longitute, string Latitude)
    {
        // вычисление велоспиденого пути между точками 

        return "45min";
    }
}


public class CarRouteStrategy : IRoute
{
    public string Navigate(string Longitute, string Latitude)
    {
        // вычисление велоспиденого пути между точками 

        return "13min";
    }
}


public class WalkRouteStrategy : IRoute
{
    public string Navigate(string Longitute, string Latitude)
    {
        // вычисление велоспиденого пути между точками 

        return "2h 35min";
    }
}


public class BusRouteStrategy : IRoute
{
    public string Navigate(string Longitute, string Latitude)
    {
        // вычисление велоспиденого пути между точками 

        return "30min";
    }







    public class Map
{
    public IRoute Route { get; set; }

    public void SetRoute(IRoute route)
    {
        Route = route;
    }

    public void ShowWayDuration(string Longitute, string Latitude)
    {
        Console.WriteLine(Route.Navigate(Longitute, Latitude));
    }



}






public class Program
{
        public static void Main(string[] args)
        {
            Map googleMap = new Map();

            BicyleRouteStrategy bicyleRouteStrategy = new BicyleRouteStrategy();
            CarRouteStrategy carRouteStrategy = new CarRouteStrategy();
            WalkRouteStrategy walkRouteStrategy = new WalkRouteStrategy();
            BusRouteStrategy busRouteStrategy = new BusRouteStrategy();

            int selected = 0;

            while (true)
            {
                Console.WriteLine("1.Bycle\n2.Car\n3.Walk\n4.Bus");
                selected = Convert.ToInt32(Console.ReadLine());


                switch (selected)
                {
                    case 1:
                        googleMap.SetRoute(bicyleRouteStrategy);
                        googleMap.ShowWayDuration(Console.ReadLine(), Console.ReadLine());
                        break;
                    case 2:
                        googleMap.SetRoute(carRouteStrategy);
                        googleMap.ShowWayDuration(Console.ReadLine(), Console.ReadLine());
                        break;
                    case 3:
                        googleMap.SetRoute(walkRouteStrategy);
                        googleMap.ShowWayDuration(Console.ReadLine(), Console.ReadLine());
                        break;
                    case 4:
                        googleMap.SetRoute(busRouteStrategy);
                        googleMap.ShowWayDuration(Console.ReadLine(), Console.ReadLine());
                        break;
                }

            }
        }
    }
}
