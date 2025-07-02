using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

public class Menu
{

    private string _input;




    
    public int displayMenu()
    {

        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        _input = Console.ReadLine();

        int choice;

        if (int.TryParse(_input, out choice))
        {
            return choice;
        }
        else
        {
            Console.WriteLine("That is not a valid option try again");
            return -1;
        }


    }

    // Declare your goal objects as fields if needed, for example:
    // private CheckListGoal checkListGoal;
   



    public int CreateGoalMenu()
    {
        Console.WriteLine("Goal type options");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select a goal type: ");
        _input = Console.ReadLine();

        int choice;

        if (int.TryParse(_input, out choice))
        {
            return choice;
        }
        else
        {
            Console.WriteLine("That is not a valid option try again");
            return -1;
        }

        
    }


}