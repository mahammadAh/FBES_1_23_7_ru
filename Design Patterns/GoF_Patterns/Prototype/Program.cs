
using Prototype;

public class Program
{
    public static void Main(string[] args)
    {
        List<Soldier> soldierList = new List<Soldier>();

        Soldier soldier = new Soldier() { Rang = "1", Weapon = "Gun" };
        while (true)
        {

            //Soldier soldier = new Soldier() { Rang = "1", Weapon = "Gun" };
            //Console.WriteLine(soldier);
            //soldierList.Add(soldier);


            var sl = soldier.Clone() as Soldier;
            Console.WriteLine(sl);
            soldierList.Add(sl);
        }
    }
}
