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
        Console.WriteLine("Welcome to quality time with yourself. Enter a number to pick a mindfulness activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflecting");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Quit");
       

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