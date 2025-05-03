using System;

class Program
{
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)


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


        Console.WriteLine($"Your name is {PromptUserName()}");

       



// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult - Accepts the user's name and the squared number and displays them.


        
    }
}

