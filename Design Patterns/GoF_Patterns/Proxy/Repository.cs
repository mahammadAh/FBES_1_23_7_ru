using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
   public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Model : {Model} \nYear : {Year} \n Price : {Price}";
        }
    }


    public  class Repository
    {
        public List<Car> Cars { get; set;}

        public Repository()
        {
            Cars = new List<Car>
            {
                new Car{Model = "Mercedes", Year = 2015 , Price = 20000},
                new Car{Model = "Toyota", Year = 2016 , Price = 35000},
                new Car{Model = "Kia", Year = 2017 , Price = 43000},
                new Car{Model = "Hyundai", Year = 2018 , Price = 23000},
                new Car{Model = "Opel", Year = 2015 , Price = 21000},
                new Car{Model = "Ford", Year = 2019 , Price = 26000},
                new Car{Model = "BMW", Year = 2012 , Price = 24000},
                new Car{Model = "Rolce Rolse", Year = 2013 , Price = 14400},
                new Car{Model = "Ferrari", Year = 2014 , Price = 17000},
                new Car{Model = "Audi", Year = 2015 , Price = 67000}
            };
        }
    }
}
