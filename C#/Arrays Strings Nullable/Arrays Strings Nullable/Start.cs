using System.Diagnostics;
using System.Text;

class Start
{
    static void Main(string[] args)
    {


        //int[] arr;  // null
        //arr = new int[10];

        //int[] arr1 = new int[5];
        //int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
        //int[] arr3 = { 10, 15, 20, 25 };

        //string[] text = new string[5];


        //int[,] arr2x1 = new int[2, 3] { { 1, 2, 3 }, { 5, 6, 7 } };
        //int[,] arr2x2 = new int[,] { { 2, 3 }, { 5, 6 }, { 10, 11 } };
        //int[,] arr2x3 = { { 11, 15 }, { 33, 45 } };


        //int rows = arr2x2.GetUpperBound(0) + 1;    // количество строк
        //int columns = arr2x2.Length / rows;

        //int[][] arr2x5 = new int[10][];
        //for (int i = 0; i < arr2x5.Length; i++)
        //{
        //    arr2x5[i] = new int[3];
        //}


        //foreach(var el in arr2x2)
        //{
        //    Console.Write(el + " ");
        //}

        //Console.WriteLine(arr2x2.Length);

        //for (int i = 0; i < rows; i++)
        //{
        //    Console.Write("Sub Array " + (i + 1) + " : ");
        //    for (int j = 0; j < columns; j++)
        //    {
        //        Console.Write(arr2x2[i,j] + " ");
        //    }
        //    Console.WriteLine();
        //}



        // создание зубчатого массива 
        //int[][] arr2x4 = new int[3][];
        //arr2x4[0] = new int[3] { 1, 2, 3 };
        //arr2x4[1] = new int[4] { 10, 15, 20, 2 };
        //arr2x4[2] = new int[2] { 6, 7 };

        //foreach (var subArr in arr2x4)
        //{
        //    foreach (var el in subArr)
        //    {
        //        el = 5;
        //    }
        //    Console.WriteLine();
        //}

        //for (int i = 0; i < arr2x4.Length; i++)
        //{
        //    for (int j = 0; j < arr2x4[i].Length; j++)
        //    {
        //        arr2x4[i][j] = 5;
        //    }
        //}




        //for(int i=0; i < arr2x4.Length; i++)
        //{
        //    Console.Write("Sub Array " + (i + 1) + " : ");
        //    for (int j= 0; j < arr2x4[i].Length; j++)
        //    {
        //        Console.Write(arr2x4[i][j]+ " ");
        //    }
        //    Console.WriteLine();
        //}



        //for (int i =0 ; i < arr.Length; i++)
        //{
        //    arr[i] = i + 5;
        //}

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}


        //var arrClone = arr2x4.Clone();
        //arr2x4.ToString();
        //Console.WriteLine(arr2x4);


        //string str1 = "Hello STEP IT";
        //string str2 = new string("Hello STEP");

        //Console.WriteLine(str1.ToUpper());
        //Console.WriteLine(str1.Replace("Hello","Bye"));
        //Console.WriteLine(str1.LastIndexOf("I"));
        //Console.WriteLine(str1.Substring(0,3));
        //var arrStr = str1.Split(' ');

        //string text1 = "Hello";
        //var text2 = text1 + " Step";
        //Console.WriteLine(text1);
        //Console.WriteLine(text2);


        //Stopwatch stopwatch = new Stopwatch();

        //string data1 = " ";
        //stopwatch.Start();
        //for (int i=0; i < 100000; i++)
        //{
        //    data1+=  i + " ";         
        //}
        //stopwatch.Stop();

        //Console.WriteLine(stopwatch.ElapsedMilliseconds);

        //stopwatch.Reset();

        //StringBuilder data2 = new StringBuilder();
        //stopwatch.Start();
        //for (int i = 0; i < 100000; i++)
        //{
        //    data2.Append(i + " ");
        //}
        //stopwatch.Stop();

        //var newData2 = data2.ToString();

        //Console.WriteLine(stopwatch.ElapsedMilliseconds);




        string str = "I love C# and hate Java ";

        string name = "Anvar";
        int age = 18;
        string studentData1 = string.Format("Hi , my name is {0}, I am {1} years old", name, age.ToString());
        string studentData2 = $"Hi , my name is {name}, I am {age.ToString()}";
        string oldStudentData =  "Hi , my name is " + name + " , I am " + age.ToString() + "years old";

    }
}

