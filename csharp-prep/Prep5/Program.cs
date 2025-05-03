using System;

class Program
{
    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(int sqrnumber, string name)
    {
        Console.WriteLine($"Your name is {name} and your number squared is {sqrnumber}");
    }

    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)

    static int SquareNumber(int number)
    {
        int sqrnumber = number*number;
        return sqrnumber;
    }

    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your fav number: ");
        int favnumber = int.Parse(Console.ReadLine());

        return favnumber;
    }

    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
       
        return name;
    }

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome(args);

        DisplayResult(SquareNumber(PromptUserNumber()), PromptUserName());
        
    }
}

