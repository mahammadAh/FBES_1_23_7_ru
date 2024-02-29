using System;
using System.Diagnostics;
using MySolution;


public class Program
{
    //public delegate void delegateToVoid();

    //public delegate void delegateToVoidWithPar(int val1, int val2);

    public delegate string CalcDelegate(int x, int y);

    public static void Main(string[] args)
    {

        //Calculate calculate = new Calculate() { Val1 = 10, Val2 = 15 };

        //delegateToVoid delegateTo1 = calculate.Sum;

        //delegateToVoidWithPar delegateTo2 = calculate.SumWithParameters;

        //delegateToVoidWithPar delegateTo3 = SumStatic;

        //delegateTo1.Invoke();

        //delegateTo2.Invoke(3, 9);

        //while (true)
        //{
        //    Console.WriteLine("Select Operatio\n1.Sum\n2.Sub\n3.Mul\n4.Div\n5.All Operations");
        //    int selected = Int32.Parse(Console.ReadLine());

        //    CalcDelegate myCalDelegate = null;

        //    switch (selected)
        //    {
        //        case 1:
        //            myCalDelegate = Calculate.Sum;
        //            break;
        //        case 2:
        //            myCalDelegate = Calculate.Sub;
        //            break;
        //        case 3:
        //            myCalDelegate = Calculate.Mul;
        //            break;
        //        case 4:
        //            myCalDelegate = Calculate.Div;
        //            break;
        //        case 5:
        //            myCalDelegate += Calculate.Sum;
        //            myCalDelegate += Calculate.Sub;
        //            myCalDelegate += Calculate.Mul;
        //            myCalDelegate += Calculate.Div;
        //            break;
        //    }

        //    Console.Write("Val1 = ");
        //    int val1 = Int32.Parse(Console.ReadLine());
        //    Console.Write("Val2 = ");
        //    int val2 = Int32.Parse(Console.ReadLine());

        //    myCalDelegate.Invoke(2, 3);

        //    foreach (CalcDelegate del in myCalDelegate.GetInvocationList())
        //    {
        //        string result = null;
        //        result = del.Invoke(val1, val2);
        //        Console.WriteLine(del.Method);
        //        Console.WriteLine(result);

        //    }


        //Action myAction1 = PrintYear;
        //myAction1 += PrintMonth;
        //myAction1 += PrintDay;

        //myAction1.Invoke();

        //Action<int, int, int> myAction2 = AddDaysAndMonthAndYearToTodayAndPrint;


        //Func<string> myFunc1 = GetDay;
        //Func<int,string> myFunc2 = AddDaysToToday;
        //Func<int, int, string> myFunc3 = AddDaysAndMonthToToday;
        //Func<int,int,int, string> myFunc4 = AddDaysAndMonthAndYearToToday;


        //Predicate<int> checkDate = CheckDay;

        // var result2 = myCalDelegate(val1, val2) ?? "Delegate is Null Here";

        //}


        List<Student> students = new List<Student>()
        {
            new Student() {Name = "Anvar" , Age = 18 , OMG = 95},
            new Student() {Name = "Nazim" , Age = 21, OMG = 12},
            new Student() {Name = "Fuad" , Age = 26,OMG = 73},
            new Student() {Name = "Ayxan" , Age = 15,OMG = 38},
            new Student() {Name = "Ayaz" , Age = 18,OMG = 99},
            new Student() {Name = "Alyona" , Age = 19,OMG = 43},
            new Student() {Name = "Dinara" , Age = 19,OMG = 90},
            new Student() {Name = "David" , Age = 18,OMG = 45},
            new Student() {Name = "Faxri" , Age = 18,OMG = 23},
            new Student() {Name = "Elnur" , Age = 27,OMG = 87},
            new Student() {Name = "Emil" , Age = 17,OMG = 23},
            new Student() {Name = "Farman" , Age = 20,OMG = 34},
        };

        //foreach (Student student in students)
        //{
        //    if(student.Age < 19)
        //    {
        //        Console.WriteLine(student.Name + " " + student.Age);
        //    }
        //}

        //students.ForEach(CheckAge);

        // students.Sort(CompareAge);
         students.Sort(CompareAge);
        students.ForEach(PrintStudent);
        Console.WriteLine();
        students.Sort(CompareOMG);
        students.ForEach(PrintStudent);

        
    }

    //public static void SumStatic(int Val1,int Val2)
    //{
    //    Console.WriteLine($"Static Method {Val1} + {Val2} = {Val1 + Val2}");
    //}

    public static void CheckAge(Student student)
    {
        if (student.Age < 19)
        {
            Console.WriteLine(student.Name + " " + student.Age);
        }
    }

    public static void PrintStudent(Student student)
    {
   
            Console.WriteLine(student.Name + " " + student.Age);
       
    }

    public static int CompareAge(Student student1, Student student2)
    {
        if(student1.Age < student2.Age)
        {
            return -1;
        }
        else if (student1.Age == student2.Age)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public static int CompareOMG(Student student1, Student student2)
    {
        if (student1.OMG < student2.OMG)
        {
            return -1;
        }
        else if (student1.OMG == student2.OMG)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public static void PrintYear()
    {
        Console.WriteLine(DateTime.Now.Year.ToString());
    }

    public static void PrintMonth()
    {
        Console.WriteLine(DateTime.Now.Month.ToString());
    }

    public static void PrintDay()
    {
        Console.WriteLine(DateTime.Now.Day.ToString());
    }

    public static string GetDay()
    {
        return DateTime.Now.Day.ToString();
    }

    public static string AddDaysToToday(int dayCount)
    {
        return DateTime.Now.AddDays(dayCount).Date.ToString();
    }

    public static string AddDaysAndMonthToToday(int dayCount,int monthCount)
    {
        return DateTime.Now.AddDays(dayCount).AddMonths(monthCount).Date.ToString();
    }

    public static string AddDaysAndMonthAndYearToToday(int dayCount, int monthCount,int yearCount)
    {
        return DateTime.Now.AddDays(dayCount).AddMonths(monthCount).AddYears(yearCount).Date.ToString();
    }

    public static void AddDaysAndMonthAndYearToTodayAndPrint(int dayCount, int monthCount, int yearCount)
    {
        Console.WriteLine( DateTime.Now.AddDays(dayCount).AddMonths(monthCount).AddYears(yearCount).Date.ToString());
    }

    public static bool CheckDay(int day)
    {
       if(day > DateTime.Now.Day)
        {
            return true;
        }
        return false;

    }



}

