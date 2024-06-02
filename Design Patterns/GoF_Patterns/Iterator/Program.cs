using System;
using System.Collections;

public class MyIntCollection : IEnumerable
{
    public int[] collection;

    public MyIntEnumerator Enumerator { get; set; }

    public MyIntCollection(params int[] ints)
    {
        collection = ints;
        Enumerator= new MyIntEnumerator(this);
    }


    public IEnumerator GetEnumerator()
    {
        return Enumerator;
    }

}



public class MyIntEnumerator : IEnumerator
{
    public MyIntCollection MyIntCollection { get; set; }

    public object Current { get; set; }

    public int index = -1;


    public MyIntEnumerator(MyIntCollection myIntCollection)
    {
        MyIntCollection = myIntCollection;
        index = myIntCollection.collection.Length;
    }


    public bool MoveNext()
    {
        if (index > 0)
        {
            index--;
            Current = MyIntCollection.collection[index];
            return true;
        }
        return false;
    }

    public void Reset()
    {
        Current = MyIntCollection.collection[0];
    }
}




class Program
{
    public static void Main(string[] args)
    {
        MyIntCollection myIntCollection = new MyIntCollection(5, 6, 7, 8, 9);

        foreach(int i in myIntCollection)
        {
            Console.WriteLine(i);
        }
    }
}