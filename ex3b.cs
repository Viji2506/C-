using System;
class STUDENT
{
    int rollNo;
    string name;
    int mark1, mark2, mark3;
    STUDENT(int r, string n, int m1, int m2, int m3)
    {
        rollNo = r;
        name = n;
        mark1 = m1;
        mark2 = m2;
        mark3 = m3;
    }
    double Average()
    {
        int total = mark1 + mark2 + mark3;
        int lowest = Math.Min(mark1, Math.Min(mark2, mark3));
        return (total - lowest) / 2.0;
    }
    void Display()
    {
        Console.WriteLine("Roll Number: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Average: " + Average());
    }
    static void Main()
    {
        Console.Write("Enter Roll Number: ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name: ");
        string n = Console.ReadLine();
        Console.Write("Enter 3 Marks: ");
        string[] marks = Console.ReadLine().Split();
        int m1 = Convert.ToInt32(marks[0]);
        int m2 = Convert.ToInt32(marks[1]);
        int m3 = Convert.ToInt32(marks[2]);
        STUDENT s = new STUDENT(r, n, m1, m2, m3);
        s.Display();
    }
}