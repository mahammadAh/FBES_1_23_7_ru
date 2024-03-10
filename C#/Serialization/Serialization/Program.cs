using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text.Json;

[AttributeUsage(AttributeTargets.All)]
public class Coder : Attribute
{
    private string Name { get; set; }

    private DateTime createdDate { get; set; }

    public Coder()
    {
        Name = "developer";
        createdDate = DateTime.Now;
    }

    public Coder(string name) 
    {
        Name = name;
        this.createdDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Created by {Name} at {createdDate}";
    }
}





//[Obsolete]
//[Coder("Mahammad Ahmadov")]

[Serializable]
public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }

    public string Profession { get; set; }

    public int height { get; set; }

    public string eyesColor { get; set; }

    public void PrintEyesColorAndHeight()
    {
        Console.WriteLine($"Eyes color : {eyesColor}\nHeight : {height}");
    }

}


[Serializable]
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


public class Program
{
    public static void Main(string[] args)
    {
        //Regex regex = new Regex("\\w\\w\\s");

        //string text = "ab 12L jgkkdl  sd d";

        //Console.WriteLine(regex.Match(text));
        //Console.WriteLine(regex.IsMatch(text));
        //var resultCollection = regex.Matches(text);

        //foreach( var result in resultCollection )
        //{
        //    Console.WriteLine(result);
        //}

        //Console.WriteLine(regex);


        //Regex mailRegex = new Regex(@"^([a-z0-9_]{10,20})@([a-z]+)(\.[a-z]{2,3})$");

        //string myMail = "ahmadov@gmail.com";

        //Console.WriteLine(mailRegex.IsMatch(myMail));

        //Regex phoneRegex = new Regex(@"^(\+[0-9]{1,3})\s([0-9]{3})-([0-9]{3})-([0-9]{2})-([0-9]{2})$");

        //string phoneNumber = "+994 055-343-76-76";

        //Console.WriteLine(phoneRegex.IsMatch(phoneNumber));

        //Person student = new Person { Name = "David", Age = 18 };

        //var result = typeof(Person).GetCustomAttributes(false);

        //foreach(var member in result)
        //{
        //    Console.WriteLine(member);
        //}


        // Binary --
        // SOAP -- 
        // XML
        // JSON 






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

        string path = "studentInfo.json";
        using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            JsonSerializer.Serialize<List<Student>>(stream, students);
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Students>));
            //xmlSerializer.Serialize(stream, students);
        }


        //string path1 = "studentInfo.xml";
        //List<Student> readedStudents = null;
        //using (Stream stream = new FileStream(path1, FileMode.Open, FileAccess.Read))
        //{
        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));

        //    readedStudents = (List<Student>)xmlSerializer.Deserialize(stream);
        //}

        //foreach (var student in readedStudents)
        //{
        //    Console.WriteLine($"Name : {student.Name} Age : {student.Age} OMG : {student.OMG}");

        //}

      


        //string path = "ListInfo.xml";
        //List<string> names = new List<string>() { "David", "Elnur", "Farman"};

        //using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
        //{
        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

        //    xmlSerializer.Serialize(stream, names);
        //}
    }
}
