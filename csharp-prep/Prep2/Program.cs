using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Enter your class score: ");
        string score = Console.ReadLine();
        int number = int.Parse(score);
        string letter = "";

        if (number >= 90)
            {
                letter = "A";
            }
        else if (number >= 80)
            {
                letter = "B";
            }
        else if (number >= 70)
            {
                letter = "C";
            }
        else if (number >= 60)
            {
                letter = "D";
            }
        else if (number < 60)
            {
                letter = "F";
            }
        else 
            {
                Console.WriteLine("Run that by me one more time? ");
            }   
        
        Console.WriteLine($"Your grade is {letter}");


         if (number >= 70)
            {
                Console.WriteLine("Congrats, you have passed");
            }
        else 
            {
                Console.WriteLine("You have Failed");
            }
    }
       
}

