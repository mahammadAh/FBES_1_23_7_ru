public class Program
{
    public static void Main(string[] args)
    {

        //var cts = new CancellationTokenSource();
        //var ct = cts.Token;

        //Task.Run(() =>
        //{
        //   for(int i=0; i<100; i++)
        //    {
        //        if (ct.IsCancellationRequested) return;
        //        Console.WriteLine(i);
        //        Thread.Sleep(100);
        //    }



        //}, ct);

        //Console.ReadKey();
        //cts.Cancel();
        //Console.ReadKey();


        //var cts = new CancellationTokenSource();
        //var ct = cts.Token;

        //PrintNumbersCallAsync(ct);

        //Console.ReadKey();
        //cts.Cancel();
        //Console.ReadKey();


        //object objA = new object();
        //object objB = new object();

        //int a = 0;
        //int b = 0;

        //Thread thread1 = new Thread( () =>
        //{
        //    Console.WriteLine("Thread - 1");
        //    lock(objA)
        //    {
        //        a++;
        //        Thread.Sleep(100);

        //        lock(objB)
        //        {
        //            b++;
        //            Thread.Sleep(100);
        //        }
        //    }

        //});

        //Thread thread2 = new Thread(() =>
        //{
        //    Console.WriteLine("Thread - 2");


        //    lock(objA)
        //    {
        //        a++;
        //        Thread.Sleep(100);

        //        lock(objB)
        //        {
        //            b++;
        //            Thread.Sleep(100);
        //        }
        //    }

        //});

        //thread1.Start();
        //thread2.Start();

    }


    //public static async void PrintNumbersCallAsync(CancellationToken ct)
    //{

    //        await PrintNumbersAsync(ct);


    //}

    //public static Task PrintNumbersAsync(CancellationToken ct)
    //{
    //     Task.Run(() =>
    //    {
    //        try
    //        {
    //            for (int i = 0; i < 100; i++)
    //            {

    //                ct.ThrowIfCancellationRequested();
    //                Console.WriteLine(i);
    //                Thread.Sleep(100);
    //            }

    //        }

    //        catch (OperationCanceledException oce)
    //        {
    //            Console.WriteLine(oce);
    //        }
    //    });


    //    return Task.CompletedTask;
    //}
}
