using AbstractFactory;
using System.Net.Http.Headers;

public class MyUnitFactory 
{ 
    public IUnitFactory UnitFactory { get; set; }


    public void AddWarriorUnitToWorld(List<Unit> units)
    {
        units.Add(UnitFactory.CreateWarrior());
    }

    public void AddRangerUnitToWorld(List<Unit> units)
    {
        units.Add(UnitFactory.CreateRanger());
    }
   
}





public class Program
{
    public static  List<Unit> units = new List<Unit>();

    public static void Main(string[] args)
    {


        MyUnitFactory myUnitFactory = new MyUnitFactory();
        
        Random rm = new Random();
        

        List<IUnitFactory> factories = new List<IUnitFactory>
        { new OrcFactory(),
          new HumanFactory(),
          new ElfFactory()    
        };

        int randomNumb;
        for (int i = 0;i <100; i++)
        {
            randomNumb = rm.Next(0, 3);
            myUnitFactory.UnitFactory = factories[randomNumb];
            randomNumb = rm.Next(0, 2);

            switch(randomNumb)
            {
                case 0:
                    myUnitFactory.AddRangerUnitToWorld(units);
                    break;
                case 1:
                    myUnitFactory.AddWarriorUnitToWorld(units);
                    break;

            }
        }
      


        PrintUnitsToConsole();

    }

    public static void PrintUnitsToConsole()
    {
       foreach (var unit in units)
        {
            Console.WriteLine(unit.ToString());
        }
    }


}
