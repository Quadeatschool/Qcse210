using System.Runtime.CompilerServices;
using System.Transactions;

public class Menu
{
    private List<string> _menuItems;


    public Menu(List<string> menuItem)
    {
        _menuItems = menuItem;
    }

    public void DisplayMenu()
    {
        for (int item = 0; item < _menuItems.Count; item++)
        {
            Console.WriteLine($"{item + 1}. {_menuItems[item]}");
        }
    }

}

