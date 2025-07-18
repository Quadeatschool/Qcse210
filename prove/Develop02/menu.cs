using System;

public class Menu
{
    public void Display()
    {
        Console.WriteLine("\nJournal Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Load the journal from a file");
        Console.WriteLine("4. Save the journal to a file");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Show total number of entries");
    }

    public int GetChoice()
    {
        Console.Write("Select an option (1-6): ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 6)
        {
            return choice;
        }
        Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
        return -1;
    }
}