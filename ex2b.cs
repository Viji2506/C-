using System;
class Program
{
    static void Area(in double b, in double h, out double area)
    {
        area = 0.5 * b * h;
    }
    static void Main()
    {
        Console.Write("Enter base: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        double h = Convert.ToDouble(Console.ReadLine());
        double area;
        Area(in b, in h, out area);
        Console.WriteLine("Area of Triangle = " + area);
    }
}