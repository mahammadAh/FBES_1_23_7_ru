using DapperCarCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCarCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;

            CarRepository carRepository = new CarRepository();

            while (!end)
            {
                Console.WriteLine("1.Add Car \n2.Show Cars \n3.Exit\n");
                int selected = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (selected)
                {
                    case 1:
                        Console.Write("Model : ");
                        string model = Console.ReadLine();
                        Console.Write("Color : ");
                        string color = Console.ReadLine();
                        Console.Write("Year : ");
                        int year =Convert.ToInt32( Console.ReadLine());

                        Car newCar = new Car
                        {
                            Model = model,
                            Color = color,
                            Year = year
                        };

                        carRepository.Add(newCar);

                        break;
                    case 2:
                        List<Car> cars = carRepository.GetAll();

                        foreach(var car in cars)
                        {
                            Console.WriteLine(car);
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        end = true;
                        break;

                }
            }

        }
    }
}
