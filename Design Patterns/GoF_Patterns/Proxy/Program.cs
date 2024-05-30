


using Proxy;

public class Program
{

    public static void Main(string[] args)
    {
        Logger logger = new Logger();

        RepositoryProxy repositoryProxy = new RepositoryProxy();
        // CLIEN -- 1

        Console.WriteLine(repositoryProxy.Get(2));
        Console.WriteLine(repositoryProxy.Get(3));


        // CLIEN -- 2
        Console.WriteLine(repositoryProxy.Get(4));
        Console.WriteLine(repositoryProxy.Get(7));

        // CLIEN -- 3

        Console.WriteLine(repositoryProxy.Get(8));
        Console.WriteLine(repositoryProxy.Get(5));


        logger.logs.ForEach(log => Console.WriteLine(log));

    }
}