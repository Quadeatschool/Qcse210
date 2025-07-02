using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

public class Menu
{

    public void displayMenu()
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            int.TryParse(input, out choice);
        }
    

    }

    // Declare your goal objects as fields if needed, for example:
    // private CheckListGoal checkListGoal;
    private EternalGoal foreverGoal = new EternalGoal("Exercise", "Run daily", 5, false, 0);



    public void CreateGoalMenu()
    {
        // You need to define 'choice' here or pass it as a parameter
        int choice = 0; // Example initialization
        switch (choice)
        {
            case 1:
                // Add logic for case 1
                break;
            // Add other cases as needed
            default:
                break;
        }
    }


}