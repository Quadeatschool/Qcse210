using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity tryBreathingActivity = new BreathingActivity(2, "Start", "End", "desc", DateTime.Now, "instructions"
);

        // Activity activity = new Activity


        

        //-----------------------------------------

        ReflectingAactivity tryReflectingAactivity = new ReflectingAactivity(2, "Start", "End", "desc", DateTime.Now, "prompt", "intructions");

       
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
                    Console.WriteLine("1. Breathing\n ");
                    tryBreathingActivity.Run();
                    break;
                case 2:
                    Console.WriteLine("2. Listing\n");
                    tryListingActivity.Run();
                    break;
                case 3:
                    Console.WriteLine("3. Reflecting\n");
                    tryReflectingAactivity.Run();
                    break;
                case 4:
                    Console.WriteLine("4. Quit\n");
                    break;
            }
        }
    }
       
}