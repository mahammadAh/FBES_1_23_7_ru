using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
   public abstract class Wizzard
    {
        public int HP { get; set; }
        public List<string> Spells { get; set; }

        public Wizzard() 
        {
            Spells = new List<string>();
        }

        public string Info()
        {
            string information = $"HP - {HP}\nSpells :\n";
            foreach (string spell in Spells)
            {
                information += spell + "\n";
            }
            return information;
        }
    }

    class AirWizzard : Wizzard
    {
        public AirWizzard()
        {
            HP = 200;
            Spells.Add("Puf-Puf");
            Spells.Add("Paf-Paf");
        }

    }


    class WaterWizzard : Wizzard
    {
        public WaterWizzard()
        {
            HP = 150;
            Spells.Add("Bul-Bul-Bul");
            Spells.Add("Bluk-Bluk-Bluk");
        }

    }

    class FireWizzard : Wizzard
    {
        public FireWizzard()
        {
            HP = 180;
            Spells.Add("Vjuuuuu");
            Spells.Add("BOM-BOM");
        }
    }

    class EarthWizzard : Wizzard
    {
        public EarthWizzard()
        {
            HP = 180;
            Spells.Add("Vxxxx-Vxxx");
            Spells.Add("Vjuk-Vjuk-Vjuk");
        }
    }

}
