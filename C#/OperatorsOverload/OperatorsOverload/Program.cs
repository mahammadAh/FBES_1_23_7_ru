using System.Diagnostics;

public class Program { 
    public static void Main(string[] args) {
        //Point point1 = new Point(5, 7);
        //point1++;
        //Console.WriteLine(point1.ToString());

        //++point1;
        //Console.WriteLine(point1.ToString());

        //--point1;
        //Console.WriteLine(point1.ToString());

        //Point minusPoint1 = -point1;
        //Console.WriteLine(minusPoint1.ToString());

        //var resultOfPlusPoints = point1 + minusPoint1;
        //Console.WriteLine(resultOfPlusPoints.ToString());

        //var resultOfMultiPointToNum =  point1 * 3;
        //Console.WriteLine(resultOfMultiPointToNum.ToString());

        //Point mainPoint = new Point(3, 4);

        //Point refPoint1 = mainPoint;
        //Point refPoint2 = mainPoint;

        //refPoint2 = resultOfMultiPointToNum;

        //if (refPoint1 == refPoint2)
        //{
        //    Console.WriteLine("refPoint1 == refPoint2");
        //}
        //else if (refPoint1 != refPoint2)
        //{
        //    Console.WriteLine("refPoint1 != refPoint2");
        //}

        //Point plusPoint1 = new Point(-1, 2);

        //if (plusPoint1)
        //{
        //    Console.WriteLine("Point true");
        //}
        //else
        //{
        //    Console.WriteLine("Point false");
        //}


        //Point pointForList1 = new Point(2, 5);
        //Point pointForList2 = new Point(4, 7);
        //Point pointForList3 = new Point(8, 3);
        //Point pointForList4 = new Point(1, 9);
        //Point pointForList5 = new Point(6, 4);

        //ListOfPoint pointsList = new ListOfPoint();

        //pointsList.AddPoint(pointForList1)
        //          .AddPoint(pointForList2)
        //          .AddPoint(pointForList3)
        //          .AddPoint(pointForList4)
        //          .AddPoint(pointForList5);


        //Console.WriteLine(pointsList[3].ToString());

        //short val3 = 10;
        //int val4 = val3;

        //int val1 = 10;
        //short val2 = (short)val1
        //

        Rectangle rectangle = new Rectangle(10,10);
        Square square = new Square(6);

        rectangle.Arrea();
        square.Arrea();


        try
        {
            var castResult = (Rectangle)rectangle;
            castResult.Arrea();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        //int val = 4;
        //short val2 = val;

    }
}


public class Point {
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int _x, int _y)
    {
        X = _x;
        Y = _y;
    }

    public static Point operator ++(Point point)
    {
        point.X++;
        point.Y++;
        return point;
    }

    public static Point operator --(Point point)
    {
        point.X--;
        point.Y--;
        return point;
    }

    public static Point operator -(Point point)
    {
        return new Point(-point.X, -point.Y);
    }

    public static Point operator -(Point point1, Point point2)
    {
        return new Point(point1.X - point2.X, point1.Y - point2.Y);
    }

    public static Point operator +(Point point1, Point point2)
    {
        return new Point(point1.X + point2.X, point1.Y + point2.Y);
    }

    public static Point operator *(Point point1, Point point2)
    {
        return new Point(point1.X * point2.X, point1.Y * point2.Y);
    }

    // *= , -= , += , /=

    public static Point operator /(Point point1, Point point2)
    {
        if (point2.X == 0 || point2.Y == 0)
        {
            throw new DivideByZeroException();
        }

        return new Point(point1.X / point2.X, point1.Y / point2.Y);
    }

    public static Point operator *(Point point1, int val)
    {
        return new Point(point1.X * val, point1.Y * val);
    }

    public static Point operator *(int val, Point point1)
    {
        return new Point(point1.X * val, point1.Y * val);
    }

    public static bool operator >(Point point1, Point point2){
        if ((point1.X + point1.Y) > point2.X + point2.Y)
        {
            return true;
        }
        else return false;
    }

    public static bool operator <(Point point1, Point point2)
    {
        if ((point1.X + point1.Y) < point2.X + point2.Y)
        {
            return true;
        }
        else return false;
    }

    public static bool operator ==(Point point1, Point point2)
    {
        return point1.Equals(point2);
    }

    public static bool operator !=(Point point1, Point point2)
    {
        return !point1.Equals(point2);
    }

    public static bool operator true(Point point)
    {
        if (point.X > 0 && point.Y > 0)
        {
            return true;
        }
        else return false;
    }


    public static bool operator false(Point point)
    {
        if (point.X < 0 || point.Y < 0)
        {
            return true;
        }
        else return false;
    }

    // && || not overload 
    // & | overload 

    // []

    //public static  operator =(Point point1,Point point2)
    //{
    //    point1.X = point2.X;
    //    point1.Y = point2.Y;
    //}

    public override string ToString()
    {
        return $"X : {this.X}\nY : {this.Y}\n";
    }
}


public class ListOfPoint {
    public List<Point> Points { get; set; }

    public ListOfPoint()
    {
        Points = new List<Point>();
    }

    public ListOfPoint AddPoint(Point point)
    {
        Points.Add(point);
        return this;
    }

    public Point this[int index]
    {
        get
        {
            return Points[index];
        }
        set
        {
            Points[index] = value;
        }
    }

}


public abstract class Figure
{
    public virtual void Arrea()
    {
    }
}


public abstract class Tetragon : Figure
{
   public int width { get; set; }
   public int hight { get; set; }
}


public class Square : Tetragon
{
    public Square(int val)
    {
        width = val;
        hight = val;
    }
    public override void Arrea()
    {
        Console.WriteLine(width * width);
    }
}

public class Rectangle : Tetragon
{
    public Rectangle(int w, int h)
    {
        width = w;
        hight = h;
    }
    public override void Arrea()
    {
    }

    // explicit | implicit 
    public static explicit operator Square(Rectangle rectangle)
    {
        if(rectangle.width == rectangle.hight)
        {
            return new Square(rectangle.width);
        }

        throw new InvalidCastException();
      
    }


   

}



