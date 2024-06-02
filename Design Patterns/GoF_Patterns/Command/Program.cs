using System.Net;

public class Command 
{ 
    public string Url { get; set; }

    public WebRequestHandler webRequestHandler { get; set; }

    public Command(string Url)
    {
        this.Url = Url;
        this.webRequestHandler = new WebRequestHandler();
    }
    public string Execute()
    {
        return webRequestHandler.GetHtmlCode(Url);
    }
}


public class WebRequestHandler
{

    public string GetHtmlCode(string url)
    {
        using (WebClient webClient = new WebClient())
        {
            return webClient.DownloadString(url);
        }
 
    }
}


public class CommnadController
{
    public List<Command> Commands { get; set; }
    public int currentCommand = -1;
    
    public CommnadController()
    {
        Commands = new List<Command>();
    }

    public void addCommand(string url)
    {
        Command newCommand = new Command(url);
        Console.WriteLine(newCommand.Execute());
        Commands.Add(new Command(url));
        currentCommand++;
    }

    public void Next()
    {
        if (currentCommand < Commands.Count-1)
        {
            Console.WriteLine(Commands[++currentCommand].Execute());
        }
        else
        {
            Console.WriteLine("It is inpossible");
        }

    }


    public void Previous()
    {
        if(currentCommand > 0)
        {
            Console.WriteLine(Commands[--currentCommand].Execute());
        }
        else
        {
            Console.WriteLine("It is inpossible");
        }

    }


}



public class Program
{
    public static void Main(string[] args)
    {
        CommnadController commnadController = new CommnadController();
        int selected = 0;

        while (true)
        {
            Console.WriteLine("1.Url \n2.Next \n3.Previous");
            selected = Convert.ToInt32(Console.ReadLine());

            if(selected == 1) 
            {
                commnadController.addCommand(Console.ReadLine());
            }
            else if(selected == 2)
            {
                commnadController.Next();
            }
            else if (selected ==3)
            {
                commnadController.Previous();
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}