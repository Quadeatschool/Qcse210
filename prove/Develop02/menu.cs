using System.Collections;

public class Menu
{
    public string _title;
    public string _description;
    public string _menuItem;

    public void DisplayTitle()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{ _description}");
        Console.WriteLine("1. Write\n 2. Display\n 3. Load\n 4. Save\n 5. Quit\n");
       
        
    }

    public int ProcessMenu()
    {
        Console.WriteLine("Which would you like to pick: ");
        string _menuItem = Console.ReadLine();
       
        if (int.TryParse(_menuItem, out int choice))
        {

            switch (choice)
            {


                case 1: Console.WriteLine("1. Write\n");
                    break;
                case 2: Console.WriteLine("2. Display\n");
                    break;
                case 3: Console.WriteLine("3. Load\n");
                    break;
                case 4: Console.WriteLine("4. Save\n");
                    break;
                case 5: Console.WriteLine("5. Quit\n");
                    break;
            }
            return choice;
        }
        else
        {
            Console.WriteLine("That is not an option on the menu, try again");
            return -1;
        }
   }
    
 }