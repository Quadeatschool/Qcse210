using System;

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
    }
}