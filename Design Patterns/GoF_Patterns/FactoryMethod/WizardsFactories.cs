using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public interface IFactory
    {
        public Wizzard Create();
    }

    public class AirWizzardFactory : IFactory
    {
        public Wizzard Create()
        {
            return new AirWizzard();
        }
    }

    public class WaterWizzardFactory : IFactory
    {
        public Wizzard Create()
        {
            return new WaterWizzard();
        }
    }


    public class FireWizzardFactory : IFactory 
    {
        public Wizzard Create() 
        {
            return new FireWizzard();
        } 
    }

    public class EarthWizzardFactory : IFactory
    {
        public Wizzard Create()
        {
            return new EarthWizzard();
        }
    }

}
