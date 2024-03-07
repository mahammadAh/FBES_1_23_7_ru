using AnonimFunctions;
using System;



public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
public class Program
{
    public delegate void printDateDel(int d, int m, int y);
    public static void Main(string[] args)
    {
        //ConsolePrint printToConsole = new ConsolePrint();

        //printDateDel _myprintDateDel = printToConsole.PrintDate;

        //printDateDel _myAnonimPrintDateDel = delegate (int d, int m, int y) { Console.WriteLine($"{d}.{m}.{y}"); }; // анонимный метод

        //// C# 2.5 -  анонимные методы
        //// C# 3.5 - лямбда

        //printDateDel _myLambdaPrintDateDel = (d, m, y) =>
        //{
        //    Console.Write($"{d}.");
        //    Console.Write($"{m}.");
        //    Console.Write($"{y}");
        //};

        //var myLambda1 = (int val) => Console.WriteLine(val);

        //var myLambda2 = () => Console.WriteLine("Hello world");





        // delegate (параметры) {тело функции} - анонимные функции
        // (параметры) => тело функции - лямбда

        //_myprintDateDel(5, 3, 2024);

        //_myAnonimPrintDateDel(5, 3, 2024);

        //_myLambdaPrintDateDel(5, 3, 2024);


        //List<int> numbers1 = new List<int>() { 4, 8, 12, 1, 14, 7, 24, 24 };
        //List<int> numbers2 = new List<int>() { 4, 8, 12, 1, 14, 7, 24, 24 };
        //List<int> numbers3 = new List<int>() { 4, 8, 12, 1, 14, 7, 24, 24 };

        //numbers1.ForEach(PrintDate);
        //Console.WriteLine();
        //var anonimFunc = delegate (int val) { Console.Write(val + " "); };
        //numbers1.ForEach(anonimFunc);
        //Console.WriteLine();
        //numbers1.ForEach(delegate (int val) { Console.Write(val + " "); });
        //Console.WriteLine();
        //// Action<T>  --> Action<int>
        //Comparison<int> mySortLambda = (int first, int second) =>
        //{
        //    if (first > second)
        //    {
        //        return -1;
        //    }
        //    else if (first < second)
        //    {
        //        return 1;
        //    }
        //    else return 0;
        //};

        //numbers1.Sort(mySortLambda);
        //numbers2.Sort(mySortLambda);
        //numbers3.Sort(mySortLambda);



        //numbers1.ForEach(x => Console.Write(x + " "));  // самый простой 
        //Console.WriteLine();


        //string data = "Od Cershenbesi";
        //data.ReverseAndPrint();


        //string myText = null;



        // LINQ ---> Language Integreted Query






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

        students.Sort((Student s1, Student s2) =>
        {
            if (s1.Age > s2.Age)
            {
                return 1;
            }
            else if (s1.Age < s2.Age)
            {
                return -1;
            }
            else return 0;
        });


        //var result = from student
        //             in students
        //             where student.Age > 19
        //             select new
        //             { 
        //                 Imya = student.Name,
        //                 Vozrast = student.Age
        //             };

        var result = students.Where(x => x.Age > 19);


        foreach (var el in result)
        {
            Console.WriteLine(el.Name + " " + el.Age);
        }



        //var resultStudents = from student
        //                     in students
        //                     group student by student.Age into s
        //                     select s;




        //foreach (var result in resultStudents)
        //{
        //    Console.WriteLine("Start Group");
        //    foreach (var res in result)
        //    {
        //        Console.WriteLine(res.Name + " " + res.Age);
        //    }
        //    Console.WriteLine("End Group\n\n");
        //}

        //List<int> ages = new List<int>() { 24, 14, 12, 1, 8, 7, 24, 4 };


        //var result = from age 
        //             in ages
        //             //where age % 2 == 0 || age % 3 == 0
        //             //orderby age ascending //
        //             //group age by age%2=0;
        //             select age;

        //foreach( var el in result)
        //{
        //    Console.Write(el + " ");
        //}



        //  ages.ForEach(x => Console.Write(x + " "));






    }
    //public static void PrintDate(int val)
    //{
    //    Console.Write(val+" ");
    //}

}
public class Student
{ 
   public string Name { get; set; }
    public int Age { get; set; }

    public int OMG { get; set; }
}


//public static class  ExstentionString
//{
//    public static void ReverseAndPrint(this string data)
//    {
//        Console.WriteLine($"{data} Novruz");
//    }
//}




