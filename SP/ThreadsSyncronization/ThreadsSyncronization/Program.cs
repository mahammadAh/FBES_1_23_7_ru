

public class Program
{
    public static void Main(string[] args)
    {
        int x = 0;

        // 1. Take x from RAM to CPU
        // 2. In CPU x= x + 1
        // 3. Return from CPU to RAM

        
        object obj = new object();

        //Mutex mutex = new Mutex();

        //Semaphore semaphore = new Semaphore(2, 3);
        

        var task1 = Task.Run(() =>
        {
            for (int i = 0; i < 100000; i++)
            {
                //Monitor.Enter(obj);
                //x++;
                //Monitor.Exit(obj);

                //lock(obj)
                //{
                //    x++;
                //}

                //mutex.WaitOne();
                //x++;
                //mutex.ReleaseMutex();

                //semaphore.WaitOne();
                //x++;
                //semaphore.Release();

                Interlocked.Increment(ref x);

            }
        });


        var task2 = Task.Run(() =>
        {
            for (int i = 0; i < 100000; i++)
            {
                //Monitor.Enter(obj);
                //x++;
                //Monitor.Exit(obj);

                //lock (obj)
                //{
                //    x++;
                //}

                //mutex.WaitOne();
                //x++;
                //mutex.ReleaseMutex();

                //semaphore.WaitOne();
                //x++;
                //semaphore.Release();

                Interlocked.Increment(ref x);
            }
        });

        
        //Console.ReadKey();

        //task1.Wait();
        //task2.Wait();

        Task.WaitAll(task1, task2);

        Console.WriteLine(x);


    }


}
