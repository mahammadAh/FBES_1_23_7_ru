using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics;



public class Math <T> 
{
   
    public T Val1 { get; set; }
    public T Val2 { get; set; }


    public T GetVal1()
    {
      
        return Val1;
    }

    public T GetVal2()
    {

        return Val2;
    }


}


public class Algorithms 
{ 
    public T GetValType<T> (T val)
    {
        return val;
    }

}


public class Cat
{
    public string Name { get; set; }
}



public class CatZooPark : IEnumerable
{
    private Cat[] Cats { get; set; }
    private int index { get; set; }
    
   

    public CatZooPark()
    {
        Cats = new Cat[5];
        index = 0;
    }

    public void Add(Cat cat)
    {
        Cats[index]= cat;
        index++;
    }

    public IEnumerator GetEnumerator()
    {
        yield return Cats[0];
        Console.WriteLine("after 1 yield");
        yield return Cats[1];
        Console.WriteLine("after 2 yield");
        yield return Cats[2];
        Console.WriteLine("after 3 yield");
      yield return Cats[3];
        Console.WriteLine("after 4 yield");
        yield return Cats[4];
        Console.WriteLine("after 5 yield");
    }

  

 


}





public class Program
{
    public static void Main(string[] args)
    {
        //ArrayList _arrayList = new ArrayList();
        //int val = 5;
        //string data = "hello";
        //Cat cat = new Cat() { Name = "Markiz" };

        //_arrayList.Add(val);
        //_arrayList.Add(data);
        //_arrayList.Add(cat);

        //var firstElement = (int)_arrayList[0];



        //ArrayList arrayList = new ArrayList();
        //Stack stack = new Stack();
        //Queue queue = new Queue();
        //Hashtable hashtable = new Hashtable();
        //hashtable.Add(1,"Hello");
        //hashtable.Add("Step", 29);


        //ICloneable
        //ICollection
        //IEnumerable
        //IEnumerator


        //  [5] --> heap
        // boxing , unboxing 


        //ArrayList arrayList = new ArrayList();
        //Stopwatch stopwatch = new Stopwatch();
        //stopwatch.Start();
        //for (int i=0; i< 10000000; i++)
        //{
        //    arrayList.Add(i); // boxing
        //}

        //foreach(object el in arrayList)
        //{
        //    int castedEl = (int)el; // unboxing
        //}
        //stopwatch.Stop();
        //Console.WriteLine(stopwatch.Elapsed.ToString());



        // Generics 

        //List<int> ints = new List<int>();
        //stopwatch.Restart();
        //for (int i = 0; i < 10000000; i++)
        //{
        //    ints.Add(i);
        //}

        //foreach (int el in ints)
        //{
        //    int result = el;
        //}
        //stopwatch.Stop();
        //Console.WriteLine(stopwatch.Elapsed.ToString());


        //Stack<int> stack = new Stack<int>();
        //Queue<int> quent = new Queue<int>();
        //List<int> list = new List<int>();
        //Dictionary<int, string> dictionary = new Dictionary<int, string>(); 

        //IEnumerable<int>
        //ICollection<int>
        //IComparable<int>
        //IDictionary<int,string>

        //Math<double> math = new Math<double>() { Val1 = 2.3, Val2 = 1.3 };
        //var val1 = math.GetVal1();
        //var val2 = math.GetVal2();
        //Console.WriteLine(val1 + val2);

        //Console.WriteLine(math.GetVal1() + math.GetVal2());

        //Algorithms algorithms = new Algorithms();
        //Console.WriteLine(algorithms.GetValType<string>("4"));

        //Math<double> math = new Math<double>() { Val1 = 2.3, Val2 = 1.3 };


        //        List<int> list = new List<int>();
        //        list.Add(1);
        //        list.Add(2);
        //        list.Add(3);
        //        list.Add(4);
        ////  Console.WriteLine(list[2]);
        //        list.Remove(1);
        //        list.AddRange(new List<int> { 1, 2, 3 });
        //        var resultList =  list.GetRange(2, 3);



        //        Stack<int> stack = new Stack<int>();
        //        stack.Push(1);
        //        stack.Push(2);
        //        stack.Pop();
        //        stack.Peek();



        //        Queue<int> queue = new Queue<int>();
        //        queue.Enqueue(1);



        //        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        //        dictionary.Add(5, "Farman");
        //        dictionary.Add(1, "Anvar");
        //        dictionary.Add(2, "Fuad");
        //        dictionary.Add(7, "David");
        //        dictionary.Add(3, "Nazim");
        //        dictionary.Add(6, "Elnur");
        //        dictionary.TryAdd(3, "Ayxan");



        //        foreach (var el in dictionary)
        //        {
        //            Console.WriteLine(el.Key + "=" + el.Value);
        //        }


        CatZooPark catZooPark = new CatZooPark();


        catZooPark.Add(new Cat() { Name = "Markiz" });
        catZooPark.Add(new Cat() { Name = "Jesika" });
        catZooPark.Add(new Cat() { Name = "Busya" });
        catZooPark.Add(new Cat() { Name = "Abrikos" });
        catZooPark.Add(new Cat() { Name = "Boris" });


        foreach (var cat in catZooPark)
        {
            Console.WriteLine(((Cat)cat).Name);
        }

        //var result = catZooPark.getLastTwoCats();

        //Console.WriteLine("End");

        //Console.Read();
    }
}
