using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Unit 
    { 
        public int HP { get; set; }
        public int Damage { get; set; }
        public abstract void Attack(Unit enemy);
    }

    public abstract class Warrior : Unit 
    {
        public override void Attack(Unit enemy)
        {
            enemy.HP -= Damage;
            Console.WriteLine("Warrior Attack ");
        }
    }

    public abstract class Ranger : Unit
    {
        public override void Attack(Unit enemy)
        {
            enemy.HP -= Damage;
            Console.WriteLine("Ranger Attack ");
        }
    }



    public class HumanMonack : Warrior
    {
        public override string ToString()
        {
            return "Human Monack";
        }
    }

    public class OrcWarlock : Warrior
    {
        public override string ToString()
        {
            return "Orc Warlock";
        }
    }

    public class ElfDruid : Warrior
    {
        public override string ToString()
        {
            return "Elf Druid";
        }
    }



    public class HumanHunter : Ranger
    {
        public override string ToString()
        {
            return "Human Hunter";
        }
    }

    public class OrcShaman : Ranger
    {
        public override string ToString()
        {
            return "Orc Shaman";
        }
    }


    public class ElfMag : Ranger
    {
        public override string ToString()
        {
            return "Elf Mag";
        }
    }




}
