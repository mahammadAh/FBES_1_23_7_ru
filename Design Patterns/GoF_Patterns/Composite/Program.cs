public abstract class Component 
{
    public string Name { get; set; }

    public Component(string name)
    {
        Name = name;
    }

    public void Add()
    {
        Console.WriteLine("Adding Inposible");
    }

    public abstract void Show();
}


public class File : Component
{
    public File(string name) : base(name) { }

    public override void Show()
    {
        Console.WriteLine(Name);
    }
}


public class Directory : Component
{
    public List<Component> Children { get; set; }


    public Directory(string name) : base(name) 
    {
        Children = new List<Component>();
    }

    public void Add(Component component)
    {
        Children.Add(component);
    }

    public override void Show()
    {
        Console.WriteLine(Name);

        foreach (Component component in Children)
        {
            component.Show();
        }
    }



}






public class Program
{



    public static void Main(string[] args)
    {

        Directory directory1 = new Directory("Papka_1");
        Directory directory2 = new Directory("Papka_2");
        Directory directory3 = new Directory("Papka_3");

        File file1 = new File("File_1");
        File file2 = new File("File_2");
        File file3 = new File("File_3");
        File file4 = new File("File_4");

        directory1.Add(file1);
        directory1.Add(directory2);
        directory2.Add(file2);
        directory2.Add(file3);
        directory2.Add(directory3);
        directory3.Add(file4);


        directory1.Show();


    }
}