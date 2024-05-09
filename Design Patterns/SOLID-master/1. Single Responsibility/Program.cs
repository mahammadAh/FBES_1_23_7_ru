﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Single_Responsibility
{
    #region BAD
    //class Report
    //{
    //    public string Text { get; set; }
    //    public void GoToFirstPage()
    //    {
    //        Console.WriteLine("Переход к первой странице");
    //    }

    //    public void GoToLastPage()
    //    {
    //        Console.WriteLine("Переход к последней странице");
    //    }

    //    public void GoToPage(int pageNumber)
    //    {
    //        Console.WriteLine("Переход к странице {0}", pageNumber);
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine("Печать отчета");
    //        Console.WriteLine(Text);
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Report report = new Report();
    //        report.Text = "Hello Wolrd";
    //        report.Print();
    //    }
    //}
    #endregion

    #region GOOD
    interface IPrinter
    {
        void Print(string text);
    }

    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    class JSonPrinter : IPrinter
    {
        public void Print(string text)
        {
            using(FileStream fs = new FileStream("printed.json",FileMode.Create,FileAccess.ReadWrite))
            {
              //  string json = JsonSerializer.Serilize(text);

            }
        }
    }

    class Report
    {
        public string Text { get; set; }

        public void GoToFirstPage()
        {
            Console.WriteLine("Переход к первой странице");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Переход к последней странице");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine("Переход к странице {0}", pageNumber);
        }
        public void Print(IPrinter printer)
        {
            printer.Print(this.Text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();
            IPrinter printerJson = new JSonPrinter();
            Report report = new Report();
            report.Text = "Hello Wolrd";
            report.Print(printerJson);
        }
    }
    #endregion
}
