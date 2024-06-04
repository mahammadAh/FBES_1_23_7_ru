
public class IdCard
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public IdCard (string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name : {Name}\nSurname : {Surname}\nAge : {Age}\n";
    }


    public IdCardMemento Save()
    {
        return new IdCardMemento
        {
            Name = Name,
            Surname = Surname,
            Age = Age
        };

    }


    public void Restore(IdCardMemento memento)
    {
        Name = memento.Name;
        Surname= memento.Surname;
        Age = memento.Age;
    }

}


public class IdCardMemento
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}





class Program
{
    public static void Main(string[] args)
    {
        IdCard NazimIdCard = new IdCard("Nazim", "Dovlatov", 21);

        Console.WriteLine(NazimIdCard);

        NazimIdCard.Surname = "Tretyakov";

        NazimIdCard.Age = 45;

        var memento1 = NazimIdCard.Save();

        NazimIdCard.Surname = "Qasanov";

        NazimIdCard.Name = "Amil";

        var memento2 = NazimIdCard.Save();

        NazimIdCard.Age = 23;


        NazimIdCard.Restore(memento2);

        Console.WriteLine(NazimIdCard);






    }
}