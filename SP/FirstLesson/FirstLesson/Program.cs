

using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        //Process.Start("notepad","text.txt");

        var processes = Process.GetProcesses();

        foreach  (var process in processes) 
        {
            try
            {
                //Console.WriteLine($"{process.Id} {process.ProcessName} {process.PriorityClass}");

                //Console.WriteLine($"{process.ProcessName} {process.MainModule}");

                //Console.WriteLine($"{process.ProcessName} :");

                //foreach(var module in process.Modules)
                //{
                //    Console.WriteLine($"\t {module}");
                //}


                //Console.WriteLine($"{process.ProcessName} {process.TotalProcessorTime}:");


                //if(process.ProcessName == "Notepad")
                //{
                //    process.Kill();
                //}

                Console.WriteLine($"{process.ProcessName} {process.TotalProcessorTime}:");
            }
            catch (Exception ex)
            {

            }
            
        }


    }
}