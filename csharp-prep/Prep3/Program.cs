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


        // for (int magic_number = 6;)
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);



        Console.WriteLine("Guess a number");
        number = int.Parse(Console.ReadLine());

        if (number == 6)
        {
            Console.WriteLine("guessed it!");
        }
        else if (number < 6)
        {
            Console.WriteLine("Higher");
            Console.WriteLine("Guess a number");
            
        }
        else
        {
            Console.WriteLine("Lower");
            Console.WriteLine("Guess a number");
            
        }
    }
}