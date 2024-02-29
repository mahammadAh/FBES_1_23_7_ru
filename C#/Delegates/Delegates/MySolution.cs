using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolution
{
    public class Calculate 
    { 
        //public int Val1 { get; set; }
        //public int Val2 { get; set; }

        //public void Sum()
        //{
        //    Console.WriteLine($"{Val1} + {Val2} = {Val1+Val2}");
        //}

        public static string Sum(int Val1,int Val2)
        {
           return $"{Val1} + {Val2} = {Val1 + Val2}";
        }

        public static string Sub(int Val1, int Val2)
        {
            return $"{Val1} - {Val2} = {Val1 - Val2}";
        }

        public static string Mul(int Val1, int Val2)
        {
            return $"{Val1} * {Val2} = {Val1 * Val2}";
        }

        public static string Div(int Val1, int Val2)
        {
            return $"{Val1} / {Val2} = {Val1 / Val2}";
        }


    }


    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int OMG { get; set; }

        public int CompareTo(Student? other)
        {
            if (this.Age < other.Age)
            {
                return -1;
            }
            else if (this.Age == other.Age)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }



}
