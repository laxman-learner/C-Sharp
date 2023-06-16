using System;

// base class
public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetCircumference();
    public virtual void PrintResults()
    // virtual means optional to override
    {
        Console.WriteLine("Printing result for some shape");
    }

}

// derived class

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public override double GetArea() => Length * Breadth;
    public override double GetCircumference() => 2 * (Length + Breadth);

    public override void PrintResults()
    {
        // base.PrintResults(); to do same as in base class

        Console.WriteLine($"Printing results for rectagle of [{Length}*{Breadth}] :");
        Console.WriteLine($"Area : {this.GetArea()}");
        Console.WriteLine($"Perimeter : {this.GetCircumference()}");

        // 'this' represents current object.

        // Console.WriteLine($"Area : {GetArea()}"); is also valid

    }


}

public class Square : Rectangle
{

    // If parameterized constructor is not defined in base class, following code is valid

    public Square(double side) : base(side, side) { }

    // base(side, side) { } means calling to the constructor of the base class

    /* If parameterized constructor is not defined in base class, following code is valid
    
    public Square(double side)
    {
        base.Length = side;
        base.Breadth = side;
    }   */

}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetCircumference() => 2 * Math.PI * Radius;


}
public class Program
{
    static void Main()
    {

        Square square = new Square(10.5);  // var square = new Square(10.5) is also valid
        var x = square.GetArea();
        Console.WriteLine($"Area is : {x}");      // string interpolation

        Rectangle rectangle = new Rectangle(32.3, 24.5);
        rectangle.PrintResults();




    }

}

