using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity tryBreathingActivity = new BreathingActivity(2, "Welcome to the Breathing Activity", "End", "This activity will walk you though a breathing exercise to help you clear your mind.", DateTime.Now, "instruct"
);


        //-----------------------------------------

        ReflectingAactivity tryReflectingAactivity = new ReflectingAactivity(2, "Start", "End", "desc", DateTime.Now, "prompt", "questions");

       
        //------------------------------------------

        // Create a list of strings
        List<string> sampleList = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3"
        };

        // Pass the list to your ListingActivity constructor
        ListingActivity tryListingActivity = new ListingActivity(
            2,
            "Start",
            "End",
            "desc",
            DateTime.Now,
            sampleList // <-- pass your list here
        );

       



    

    Menu menu = new Menu();
    menu.DisplayTitle();
        

        int choice = 0;
        while (choice != 4)
        {
           choice = menu.ProcessMenu();
            switch (choice)
            {
                case 1:
                    tryBreathingActivity.Run();
                    break;
                case 2:
                    tryListingActivity.Run();
                    break;
                case 3:
                    tryReflectingAactivity.Run();
                    break;
                case 4:
                    break;
            }
        }
    }
       
}