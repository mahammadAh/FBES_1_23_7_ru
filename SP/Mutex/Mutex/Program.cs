namespace MutexApp
{
    internal static class Program
    {
       

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
         [STAThread]
        static void Main()
        {
            bool isCreatedNew = false;

            Mutex mutex = new Mutex(true,"chrome", out isCreatedNew);

            if (!isCreatedNew)
            {
                MessageBox.Show("You can't run second App ");
                Environment.Exit(0);
            
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}