using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>(); 
        int number = -1;
        while (number != 0 )
        {
            Console.WriteLine("enter a number to be added to the number list, enter 0 when you are bored of the loop: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        

        Console.WriteLine($"number of items in number list: {numbers.Count} ");
        foreach (int item in numbers)
        {
             Console.WriteLine(item);
        }

        int max = numbers.Max();
        Console.WriteLine($"The largest number is {max}");

        int sum = numbers.Sum();
        Console.WriteLine($"The numbers in the list added together is {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average of the numbers in the list of numbers {average}");


    }
}