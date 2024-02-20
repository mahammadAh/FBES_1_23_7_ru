using System.Collections;
using System.ComponentModel;
using System.Data.Common;

public class Human
{
    public string Name { get; set; }
    public int Age { get; set; } 

    public Human(string name , int age)
    {
        Name = name;
        Age = age;
    }
}


public interface IEmployee
{
    public string Level { get; set; }
    public void Working();
}


public interface ISkills {
    public List<string> skills { get; set; }

    public void ShowSkills();
}



public class Developer : Human, IEmployee , ISkills
{
    public string Level { get; set; }
    public List<string> skills { get ; set ; } = new List<string>();

    public Developer(string name, int age, string level ) : base(name, age) 
    {
        Level = level;
    }

    public void Working()
    {
        Console.WriteLine($"{Name} is writing code...");
    }

    public void ShowSkills()
    {
        Console.WriteLine("Developers skills : ");
       foreach(string skill in skills)
        {
            Console.Write($"{skill}, ");
        }
    }
}



public class Accountant : Human , IEmployee , ISkills
{
    public string Level { get; set; }
    public List<string> skills { get; set; } = new List<string>();

    public Accountant(string name, int age,string level) : base(name, age) 
    { 
        Level = level;
    }

    public void Working()
    {
        Console.WriteLine($"{Name} is checking black budget...");
    }

    public void ShowSkills()
    {
        Console.WriteLine("Accountant skills : ");
        foreach (string skill in skills)
        {
            Console.Write($"{skill}, ");
        }
    }
}




public interface A 
{
    public void Show();
}


public interface B 
{
    public void Show();
}

public interface C 
{

    public void Show();
}


public class alpha : A,C,B
{


     void A.Show()
    {
        Console.WriteLine("A");
    }

    void B.Show()
    {
        Console.WriteLine("B");
    }

    public void Show()
    {
        Console.WriteLine("C");
    }



    //public void Show()
    //{
    //    throw new NotImplementedException();
    //}

    //public void Show()
    //{
    //    throw new NotImplementedException();
    //}
}



public class Student  : IComparable
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Student()
    {
       
    }

    public Student (string name , int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name : {Name}\nAge : {Age}\n\n";
    }

    public int CompareTo(object? obj)
    {
        // return Age.CompareTo((obj as Student).Age);
        return (obj as Student).Age.CompareTo(this.Age);
    }
}


public class Group : IEnumerable 
{ 
    public string GroupNo { get; set; }
    public List<Student> Students { get; set; }

    public Group()
    {
        Students = new List<Student>();
    }

    public Group(string GroupNo) : this()
    {
        GroupNo = GroupNo;
    }

    public Student this[int index] { 
        get
        {
            return Students[index];
        }
        set
        {
            Students.Add(value);
        }
    }


    public IEnumerator GetEnumerator()
    {
        return Students.GetEnumerator();
    }

    

}









public class Program
{
    public static void Main(string[] args) {

        //Developer devNo1 = new Developer("Nazim", 20);
        //Accountant accNo1 = new Accountant("Fuad", 26);


        //List<IEmployee> employees = new List<IEmployee>();
        //employees.Add(devNo1);
        //employees.Add(accNo1);

        //_Developer _devNo1 = new _Developer("Nazim", 20);
        //_Accountant _accNo1 = new _Accountant("Fuad", 26);

        //baseClassEmployee employee = _devNo1;
        //employee.Working();

        //Developer devNo1 = new Developer("Nazim", 20,"Junior");
        //Accountant accNo1 = new Accountant("Fuad", 26,"Strong");

        //IEmployee bestEmployee = devNo1;
        //bestEmployee.Working();

        //devNo1.skills.Add("C#");
        //devNo1.skills.Add("SQL");
        //devNo1.skills.Add("Design Patterns");


        //accNo1.skills.Add("Excell");
        //accNo1.skills.Add("1C");
        //accNo1.skills.Add("B3");


        //accNo1.ShowSkills();

        //ISkills employeeSkill = accNo1;


        //foreach (IEmployee employee in employees)
        //{
        //    employee.Working();
        //}

        //alpha newClass = new alpha();

        //B refC = newClass;

        //refC.Show();

        //A refA = newClass;

        //refA.Show();

        //newClass.Show();


        //Group FBES_1_23_7_ru = new Group("FBES_1_23_7_ru");

        //FBES_1_23_7_ru.Students.Add(new Student("Ayaz", 18));
        //FBES_1_23_7_ru.Students.Add(new Student("Alyona", 19));
        //FBES_1_23_7_ru.Students.Add(new Student("Nazim", 21));
        //FBES_1_23_7_ru.Students.Add(new Student("Fuad", 26));
        //FBES_1_23_7_ru.Students.Add(new Student("Elnur", 27));


        //foreach(Student student in FBES_1_23_7_ru)
        //{
        //    Console.WriteLine(student.ToString());
        //}


        List<Student >students = new List<Student> { new Student("Elnur", 27), new Student("Alyona", 19), new Student("Anvar", 18), new Student("Nazim", 21), new Student("Fuad", 26) };


       students.Sort();

        foreach (Student student in students)
        {
            Console.WriteLine(student.ToString());
        }




    }

}
