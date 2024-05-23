

using Builder;



public class Program
{
    public static void Main(string[] args)
    {
        HumanBuilder Anvar = new HumanBuilder();

        Anvar.SetName();
        Anvar.SetDescription();

        Thread.Sleep(1000);

        Anvar.HasKnife();

        Thread.Sleep(1000);

        Anvar.HasArch();
    }
}
