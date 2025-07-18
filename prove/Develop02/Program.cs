using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Menu menu = new Menu();
        Questions questions = new Questions();
        bool running = true;
        while (running)
        {
            menu.Display();
            int choice = menu.GetChoice();
            switch (choice)
            {
                case 1:
                    // Write a new entry
                    string prompt = questions.NextQuestion();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    JournalEntry entry = new JournalEntry(DateTime.Now, prompt, response);
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added!\n");
                    break;
                case 2:
                    // Display the journal
                    journal.Display();
                    break;
                case 3:
                    // Load from file
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case 4:
                    // Save to file
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case 5:
                    // Quit
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                // Creativity: counts entries
                case 6:
                    journal.CountEntries();
                    break;
                default:
                    // Invalid
                    Console.WriteLine("Invalid choice, please enter a number 1-6.\n");
                    break;
            }
        }
    }
}