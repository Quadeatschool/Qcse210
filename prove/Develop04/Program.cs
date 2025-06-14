using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Console.WriteLine("1. 2. 3.");


        Menu menu = new Menu();
        menu.DisplayTitle();
        menu.ProcessMenu();

    }
}