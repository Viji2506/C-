using System;
class Circle
{
    double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public double Area()
    {
        return Math.PI * radius * radius;
    }
    public double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Circle c = new Circle(r);
        Console.WriteLine("Area = " + c.Area());
        Console.WriteLine("Perimeter = " + c.Perimeter());
    }
}
