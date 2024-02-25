using System.Runtime.InteropServices;

class Person : IDisposable
{ 

    public string Name { get; set; }
    public int Age { get; set; }

    private bool _disposed = false;

    public override string ToString()
    {
        return $"Name : {Name} , Age : {Age}";
    }

    public void Dispose()
    {
        Console.WriteLine("Освобождение не управляемых ресурсов");
        _disposed = true;
    }

    ~Person()
    {
        if(!_disposed)
        {
            Console.WriteLine("Finilize worked");
            throw new Exception();
        }
      
    }
}


public class Program { 
    public static void Main(string[] args)
    {
        //Person student1 = new Person() {Name = "Elnur", Age = 27 };
        //Person student2 = new Person() { Name = "Alyona", Age = 19 };
        //Person student3 = new Person() { Name = "Anvar", Age = 18 };
        //Person student4 = new Person() { Name = "Ayaz", Age = 18 };
        //Person student5 = new Person() { Name = "David", Age = 18 };

        //List<Person> students = new List<Person>();
        //students.Add(student1);
        //students.Add(student2);
        //students.Add(student3);
        //students.Add(student4);
        //students.Add(student5);

        //GC.Collect();

        //foreach (Person person in students)
        //{
        //   Console.WriteLine(person.ToString());
        //}

        
       



        using(Person student = new Person() { Name = "Ayxan", Age = 15 })
        {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Age);
                Console.WriteLine(student);
        }


        Person student1 = new Person() { Name = "Ayxan", Age = 15 };
        Console.WriteLine(GC.GetGeneration(student1));
        try
        {           
            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Age);
            Console.WriteLine(student1);
        }
        finally
        {
            student1.Dispose();
        }



    }
}

