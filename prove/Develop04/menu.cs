public class Menu
{
    private string _title;
    private string _description;
    private string _menuItem;

    public void DisplayTitle()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{ _description}");
        
        
    }

    public int ProcessMenu()
    {
        Console.WriteLine("Welcome to quality time with yourself. Enter a number to pick a mindfulness activity.\n1. Breathing\n 2. Listing\n 3. Reflecting\n 5. Quit\n");
       
        Console.WriteLine("Which would you like to pick: ");
        string _menuItem = Console.ReadLine();
       
        if (int.TryParse(_menuItem, out int choice))
        {

            
            return choice;
        }
        else
        {
            Console.WriteLine("That is not an option on the menu, try again");
            return -1;
        }
   }
    
 }