using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        BreathingActivity tryBreathingActivity = new BreathingActivity(
            2,
            "Welcome to the Breathing Activity",
            "End",
            "This activity will walk you though a breathing exercise to help you clear your mind.",
            "Breathe in...|Breathe out..."
);


        //-----------------------------------------

        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel when it was complete?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        ReflectingActivity tryReflectingActivity = new ReflectingActivity(
            2, "Welcome to the Reflecting Activity.", $"You have completed another seconds of the Reflecting Activity.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", prompts, questions);

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
                    tryReflectingActivity.Run();
                    break;
                case 4:
                    break;
            }
        }
    }
       
}