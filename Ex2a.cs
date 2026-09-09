using System;
class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
        Swap(ref a, ref b);
        Console.WriteLine("After swapping: a = " + a + ", b = " + b);
    }
}