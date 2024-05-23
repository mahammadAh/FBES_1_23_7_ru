using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class  IUnitFactory 
    {
        public abstract Warrior CreateWarrior();
        public abstract Ranger CreateRanger();
    }


    public class HumanFactory : IUnitFactory
    {
        public override Ranger CreateRanger()
        {
            return new HumanHunter();
        }

        public override Warrior CreateWarrior()
        {
            return new HumanMonack();
        }
    }


    public class OrcFactory : IUnitFactory
    {
        public override Ranger CreateRanger()
        {
            return new OrcShaman();
        }

        public override Warrior CreateWarrior()
        {
            return new OrcWarlock();
        }
    }


    public class ElfFactory : IUnitFactory
    {
        public override Ranger CreateRanger()
        {
            return new ElfMag();
        }

        public override Warrior CreateWarrior()
        {
            return new ElfDruid();
        }
    }

}
