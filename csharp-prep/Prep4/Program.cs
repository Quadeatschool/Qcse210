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
            Console.WriteLine("enter a number to be added to the number list: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        
        Console.WriteLine(numbers.Count);

        Console.WriteLine("Items in number list: ");
        foreach (int item in numbers)
        {
             Console.WriteLine(item);
        }
        
    }
}