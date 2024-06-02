public abstract class Handler
{
    public Handler Succesor { get; set; }
    public void SetSuccesor(Handler handler)
    {
        Succesor = handler;
    }

    public abstract void Processing(int data);

}


public class FirstChainHandler : Handler
{
    public override void Processing(int data)
    {
        if(data > 0 && data <= 10)
        {
            Console.WriteLine("Processing - First Chain Handler");
        }
        else if (Succesor != null)
        {
            Succesor.Processing(data);
        }
        else
        {
            Console.WriteLine("Can't find Handler");
        }
    }
}

public class SecondChainHandler : Handler
{
    public override void Processing(int data)
    {
        if (data > 10 && data <= 20)
        {
            Console.WriteLine("Processing - Second Chain Handler");
        }
        else if (Succesor != null)
        {
            Succesor.Processing(data);
        }
        else
        {
            Console.WriteLine("Can't find Handler");
        }
    }
}


public class ThirdChainHandler : Handler
{
    public override void Processing(int data)
    {
        if (data > 20 && data <= 30)
        {
            Console.WriteLine("Processing - Third Chain Handler");
        }
        else if (Succesor != null)
        {
            Succesor.Processing(data);
        }
        else
        {
            Console.WriteLine("Can't find Handler");
        }
    }
}


// www.stepit.com                   172.67.165.21    
// www.stepit.com/Contacts          172.67.165.21/Contacts 
// www.stepit.com/Vacancy           172.67.165.21/Vacancy 
// www.stepit.com/Students          172.67.165.21/Students 
// www.stepit.com/Programs          172.67.165.21/Programs 



public class Program
{
    public static void Main(string[] args)
    {

        FirstChainHandler firstChainHandler = new FirstChainHandler();
        SecondChainHandler secondChainHandler = new SecondChainHandler();
        ThirdChainHandler thirdChainHandler = new ThirdChainHandler();


        firstChainHandler.SetSuccesor(secondChainHandler);
        secondChainHandler.SetSuccesor(thirdChainHandler);


        List<int> data = new List<int> { 11, 33, 2, 45,23, 6, 14 };


        foreach(int i in data)
        {
            firstChainHandler.Processing(i);
        }
    }
}