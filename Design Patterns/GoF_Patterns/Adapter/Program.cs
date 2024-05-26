using System.Drawing;

public interface IShape
{
    public void Draw(int y1 , int x1, int y2 , int x2);
}


public class CircleAdapter : IShape
{
    public Circle circle { get; set; }

    public CircleAdapter(Circle circle)
    {
        this.circle = circle;
    }

    public void Draw(int y1, int x1, int y2, int x2)
    {
        var radius = ((y2 + x2) - (y1 + x1)) / 2;
        var x = x1;
        var y = y1;
        circle.Draw(x,y, radius);
    }
}


public class RectangleAdapter : IShape
{
    public Rectangle rectangle { get; set; }

    public RectangleAdapter(Rectangle rectangle)
    {
        this.rectangle = rectangle;
    }

    public void Draw(int y1, int x1, int y2, int x2)
    {
        var heigth = x2 - x1;
        var width = y2 - y1;
        var x = x1;
        var y = y1;
        rectangle.Draw(x,y, width, heigth);
    }
}


public class LineAdapter : IShape
{
    public Line line { get; set; }

    public LineAdapter(Line line)
    {
        this.line = line;
    }

    public void Draw(int y1, int x1, int y2, int x2)
    {
        var length = ((y2 + x2) - (y1 + x1)) / 2;
        var x = x1;
        var y = y1;
        line.Draw(x, y, length);
    }
}



public class Circle
{
    public void Draw(int x, int y, int radius)
    {
        Console.WriteLine($"x : {x} \n y : {y} \n radius : {radius}\n");
    }
}


public class Rectangle
{
    public void Draw(int x, int y, int width, int heigth)
    {
        Console.WriteLine($"x : {x} \n y : {y} \n width : {width}\n heigth : {heigth}\n" );
    }
}


public class Line
{
    public void Draw(int x, int y, int lineSize)
    {
        Console.WriteLine($"x : {x} \n y : {y} \n lineSize : {lineSize}\n");
    }
}









public class Program
{
    public static void Main(string[] args)
    {
       



        //List<object> shapes = new List<object>
        //{
        //    new Circle(),
        //    new Rectangle(),
        //    new Line()
        //};

        //foreach( object shape in shapes ) 
        //{ 
        //    if(shape is Circle)
        //    {
        //        var obj = shape as Circle;
        //        obj.Draw(5, 3, 4);
        //    }
        //    else if (shape is Rectangle)
        //    {
        //        var obj = shape as Rectangle;
        //        obj.Draw(3, 7, 4,11);
        //    }
        //    else if (shape is Line)
        //    {
        //        var obj = shape as Line;
        //        obj.Draw(5, 9, 33);
        //    }
        //}

        List<IShape> shapes = new List<IShape>
        {
            new CircleAdapter(new Circle()),
            new RectangleAdapter(new Rectangle()),
            new LineAdapter(new Line())

        };


        foreach(IShape shape in shapes)
        {
            shape.Draw(4, 5, 6, 7);
        }


    }
}