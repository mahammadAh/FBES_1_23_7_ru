


public class Program
{
    public static void Main(string[] args)
    {

        //ThreadStart threadStartFirst = new ThreadStart(PrintDataFirst);

        //Thread threadFirst = new Thread(threadStartFirst);

        //Thread threadFirst = new Thread(PrintDataFirst);

        //ThreadStart threadStartFirst = () => { Console.WriteLine("Hello"); };

        //Thread threadFirst = new Thread(() =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Первичный");
        //        Thread.Sleep(20);
        //    }
        //});

        //threadFirst.Start();



        //new Thread(() =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Первичный");
        //        Thread.Sleep(20);
        //    }
        //}).Start();




        //ThreadStart threadStartSecond = new ThreadStart(PrintDataSecond);

        //Thread threadSecond = new Thread(threadStartSecond);

        //Thread threadSecond = new Thread(PrintDataSecond);

        //Thread threadSecond = new Thread(() =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("\tВторичный");
        //        Thread.Sleep(20);
        //    }
        //});

        //threadSecond.Start();

        //PrintDataFirst();
        //PrintDataSecond();




        //Thread threadFirst = new Thread(PrintData);

        //threadFirst.Start("Первичный");

        //Thread threadSecond= new Thread(PrintData);

        //threadSecond.Start("\tВторичный");


        //Thread threadStep = new Thread(() =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("STEP IT ACADEMY");
        //    }
        //});

        //threadStep.IsBackground = true;

        //threadStep.Start();




        // ThreadPool.QueueUserWorkItem((param) =>
        // {
        //     while (true)
        //     {
        //         Console.WriteLine("Первичный");
        //         Thread.Sleep(20);
        //     }
        // });


        // ThreadPool.QueueUserWorkItem((param) =>
        // {
        //     while (true)
        //     {
        //         Console.WriteLine("\tВторичный");
        //         Thread.Sleep(20);
        //     }
        // });



        //Console.ReadLine();


        //Action action = () =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Первый");
        //    }
        //};

        //Task task = new Task(action);

        //task.Start();

        //Task.Run(() =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Первый");
        //    }
        //});


        //Task.Run(() =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("\tВторой");
        //    }
        //});



        Task task = new Task(() =>
        {
            while (true)
            {
                Console.WriteLine("Step IT");
            }
        });

       
        task.Start();



        Console.ReadLine();
    }




    //public static void PrintDataFirst()
    //{
    //    while (true)
    //    {
    //        Console.WriteLine("Первичный");
    //        Thread.Sleep(20);
    //    }

    //}

    //public static void PrintDataSecond()
    //{
    //    while (true)
    //    {
    //        Console.WriteLine("\tВторичный");
    //        Thread.Sleep(20);
    //    }
    //}


    public static void PrintData(object obj)
    {
        while (true)
        {
            Console.WriteLine(obj.ToString());
            Thread.Sleep(20);
        }
    }
}

