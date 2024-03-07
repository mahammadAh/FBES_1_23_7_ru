namespace AnonimFunctions
{
    public class ConsolePrint
    {
        public void PrintDate(int day, int month, int year)
        {
            //string strDay = day.ToString();
            //if(day <= 9)
            //{
            //    strDay = "0"+ day.ToString();
            //}

            //string strMonth = month.ToString();
            //if (month <= 9)
            //{
            //    strMonth = "0" + month.ToString();
            //}

            Console.WriteLine($"{day}.{month}.{year}");
        }
    }



}