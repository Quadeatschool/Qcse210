using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // string me = "quade";
        // while (me == "quade")
        // {
        //     Console.WriteLine("who am I? ");
        //     me = Console.ReadLine();
        // }

        // string you;

        // do
        // {
        //     Console.WriteLine(" are you a person?");
        //     you = Console.ReadLine();
        // } while (you == "yes");


     
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;

        do
        {
            Console.WriteLine("Guess a number between 1 and 100");
            guess = int.Parse(Console.ReadLine());
        }  while (guess != number);

        
        if (guess == number)
        {
            Console.WriteLine("guessed it!");
        }
        else if (guess < number)
        {
            Console.WriteLine("Higher");
            Console.WriteLine("Guess a number");
            
        }
        else if (guess > number)
        {
            Console.WriteLine("Lower");
            Console.WriteLine("Guess a number");
            
        }
        else 
        {
            Console.WriteLine("nice try poser");
        }
    }
}