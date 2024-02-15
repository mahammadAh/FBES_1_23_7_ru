using System.Reflection.Emit;

public abstract class Human 
{
    public  string Name { get; set; }
    public int Age { get; set; }

    public Human(string name,int age)
    {
       Name = name;
       Age = age;
    }



}


public abstract class Employee : Human
{
    public string Position { get; set; }

    public Employee(string name, int Age, string position) : base(name, Age)
    {

        Position = position;
    }


   // public abstract void ShowInfo();

}



public class Developer : Employee
{
    public List<string> Skills { get; set; } = new List<string>();
    public string Level { get; set; }

    public Developer (string Name , int Age , string Position ,List<string> skills, string level) : base(Name, Age, Position)
    {
        foreach(string skill in skills)
        {
            Skills.Add(skill);
        }

        Level = level;
    }

    //public override void ShowInfo()
    //{
    //    Console.WriteLine($"Name : {base.Name} \nAge : {base.Age} \nPosition : {Position} \nSkills : ");
    //    foreach (string skill in Skills)
    //    {
    //        Console.Write($"{skill}, ");
    //    }
    //    Console.WriteLine($"\nLevel : {Level}");
    //}

    public override string ToString()
    {
        var text = $"Name : {base.Name} \nAge : {base.Age} \nPosition : {Position} \nSkills : ";
        foreach (string skill in Skills)
        {
            text += $"{skill}, ";
        }
        text += $"\nLevel : {Level}";
        return text;
    }
}


public class Director : Employee
{
    public int CountOfStaff { get; set; }

    public int Experince { get; set; }

    public Director(string Name, int Age, string Position,int countOfStaff, int experince) : base(Name, Age, Position)
    {
        CountOfStaff = countOfStaff;
        Experince = experince;
    }

    //public override void ShowInfo()
    //{
    //    Console.WriteLine($"Name : {base.Name} \nAge : {base.Age} \nPosition : {Position} \nCount Of Staff : {CountOfStaff} \nExperince : {Experince}");

    //}

    public override string ToString()
    {
        return $"Name : {base.Name} \nAge : {base.Age} \nPosition : {Position} \nCount Of Staff : {CountOfStaff} \nExperince : {Experince}";
    }

}



    public class Cooker : Employee
    {
        public bool isMichlenStart { get; set; }
        public Cooker(string name, int Age, string position, bool isMichlenStart) : base(name, Age, position)
        {
            this.isMichlenStart = isMichlenStart;
        }

     
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //Employee Vuqar = new Employee("Vuqar",21, "Teacher");

            //Human HumanEmployee = Vuqar;


            //Human Ayxan = new Human("Ayxan",16);

            //Employee employee = Ayxan;

            //Vuqar.ShowPositon();
            //Console.WriteLine();


            //((Employee)firstEmployee).Print();

            //var simpleEmployee = HumanEmployee as Employee;
            //simpleEmployee.ShowPositon();

            //if(HumanEmployee is Employee)
            //{
            //    var simpleEmployee = HumanEmployee as Employee;
            //    simpleEmployee.ShowPositon();
            //}

            // Vuqar.Print();



            Developer Anvar = new Developer("Anvar", 18, "Developer", new List<string>() { "Python", "C++", "Git" }, "Junior");

            Director Fuad = new Director("Fuad", 26, "Director", 20, 6);


            Random random = new Random();
            int rChoose = random.Next(0, 2);

            Employee monthEmpolee = null;

            switch (rChoose)
            {
                case 0:
                    monthEmpolee = Anvar;
                    break;
                case 1:
                    monthEmpolee = Fuad;
                    break;
            }

           Console.WriteLine(monthEmpolee?.ToString());

         
            //string data = "Hello";

            //Console.WriteLine(Anvar.ToString());

           

        }
    }

