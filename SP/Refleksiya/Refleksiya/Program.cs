

using MyLibrary;
using System.Dynamic;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello World");

        //MyClass myClass = new MyClass();

        //myClass.PrintHelloStep();

        //Assembly assembly = Assembly.GetExecutingAssembly();

        //Console.WriteLine(assembly+"\n\n");

        //Console.WriteLine(assembly);
        //Type[] types = assembly.GetTypes();

        //foreach (Type type in types)
        //{
        //    Console.WriteLine("\n"+type);

        //    var members = type.GetMembers();

        //    foreach(MemberInfo member in members)
        //    {
        //        Console.WriteLine("\t"+member.Name);
        //    }
        //}

        string url = "https://lb.itstep.org/Car/PrintModel/2";

        string[] urlParts = url.Split('/');

        string typeName = urlParts[urlParts.Length - 3];

        string methodName = urlParts[urlParts.Length - 2];

        string parametr = urlParts[urlParts.Length - 1];

        Assembly assembly = Assembly.GetExecutingAssembly();

        Type type = assembly.GetType(typeName);

        var createdObject = Activator.CreateInstance(type);

        MethodInfo method = type.GetMethod(methodName);

        method.Invoke(createdObject, new object[] { parametr } );





    }

}


public class Car
{
    string Model { get; set; }
    string Color { get; set; }

    public Car()
    {
        Model = "BMW";
        Color = "Red";
    }

    public void PrintModel(string id)
    {
        switch (id)
        {
            case "1":
                Console.WriteLine("BMW");
                break;
            case "2":
                Console.WriteLine("Tesla");
                break;
            case "3":
                Console.WriteLine("Kia");
                break;
        }
      
    }

    public void PrintColor() { 
        Console.WriteLine($"{Color}");
    }

    public override string ToString()
    {
        return base.ToString()+"  STEP";
    }
}
