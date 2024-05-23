using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Soldier : ICloneable
    {
       public string Rang { get; set; }
       public string Weapon { get; set; }

       public Soldier()
       {
            Console.WriteLine("Load Data From DB...");
            Thread.Sleep(300);
          
       }

        public object Clone()
        {
           return this.MemberwiseClone() ;
        }

        public override string ToString()
        {
            return $"Rang : {Rang} , Weapon : {Weapon}";
        }
    }
}
