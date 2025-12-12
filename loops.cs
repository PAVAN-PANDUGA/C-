using System;

class LoopsExample
{
    static void Main(string[] args)
    {
        // For loop
        Console.WriteLine("For Loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"i = {i}");
        }

        // While loop
        Console.WriteLine("\nWhile Loop:");
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine($"j = {j}");
            j++;
        }

        // Do-While loop
        Console.WriteLine("\nDo-While Loop:");
        int k = 0;
        do
        {
            Console.WriteLine($"k = {k}");
            k++;
        } while (k < 5);

        // Foreach loop
        Console.WriteLine("\nForeach Loop:");
        int[] numbers = { 10, 20, 30, 40, 50 };
        foreach (int num in numbers)
        {
            Console.WriteLine($"Number: {num}");
        }
    }
}