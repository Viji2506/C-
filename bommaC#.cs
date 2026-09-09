
using System;
class JaggedArraySum
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Enter elements for row {i + 1} (separated by spaces): ");
            string input = Console.ReadLine();
            string[] elements = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            jaggedArray[i] = new int[elements.Length];
            for (int j = 0; j < elements.Length; j++)
            {
                jaggedArray[i][j] = int.Parse(elements[j]);
            }
        }
        Console.WriteLine("\n--- Results ---");
        int totalSum = 0;
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                rowSum += jaggedArray[i][j];
            }
            Console.WriteLine($"Sum of Row {i + 1} = {rowSum}");
            totalSum += rowSum;
        }
        Console.WriteLine($"Total Sum of Matrix = {totalSum}");
    }
}