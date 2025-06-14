public class Menu
{
    private string _title;
    private string _description;
    private string _menuItem;

    public void DisplayTitle()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{ _description}");
        Console.WriteLine("Welcome to quality time with yourself. Enter a number to pick a mindfulness activity.\n1. Breathing\n 2. Listing\n 3. Reflecting\n 5. Quit\n");
       
        
    }

    public int ProcessMenu()
    {
        Console.WriteLine("Which would you like to pick: ");
        string _menuItem = Console.ReadLine();
       
        if (int.TryParse(_menuItem, out int choice))
        {

            switch (choice)
            {


                case 1: Console.WriteLine("1. Breathing\n");
                    break;
                case 2: Console.WriteLine("2. Listing\n");
                    break;
                case 3: Console.WriteLine("3. Reflecting\n");
                    break;
                case 4: Console.WriteLine("4. Quit\n");
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