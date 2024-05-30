using System.Text;

//public class UpgradedStringBuilder : StringBuilder
//{

//}



public class StringBuilderDecorator
{
    public StringBuilder stringBuilder;

    public StringBuilderDecorator()
    {
        stringBuilder = new StringBuilder();

    }


    public StringBuilderDecorator Append(string? value)
    {
         stringBuilder.Append(value + "@");
         return this;
    }


    public StringBuilderDecorator AppendLine(string? value)
    {
        stringBuilder.AppendLine(value);
        return this;
    }


   public override string ToString()
    {
        return stringBuilder.ToString();
    }






}


public class Program
{
    public static void Main(string[] args)
    {
        StringBuilder strBld  = new StringBuilder();
        strBld.Append("Hello ");
        strBld.Append("Step ");
        strBld.Append("IT !");


        StringBuilderDecorator strBldDecorator = new StringBuilderDecorator();
        strBldDecorator.Append("Hello ");
        strBldDecorator.Append("Step ");
        strBldDecorator.Append("IT !");


        Console.WriteLine(strBld);
        Console.WriteLine(strBldDecorator);


    }
}
