using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");


        // Menu


        Menu Mymenu = new Menu();

        Mymenu._title = "Main Menu";

        Mymenu._description = "Pick one of the following Items depending on the task you'd like to do";

        Mymenu.DisplayTitle();

        Mymenu.ProcessMenu();



        // Questions

        Questions newQuestion = new Questions();
        string randomQuestion = newQuestion.NextQuestion();
        Console.WriteLine($"{randomQuestion}");


    }


   
}