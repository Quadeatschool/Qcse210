using System;
using System.Collections.Generic; // <-- don't forget this

class Program
{
    static void Main(string[] args)
    {

        Menu menu = new Menu();
        menu.DisplayTitle();
        menu.ProcessMenu();

        BreathingActivity tryBreathingActivity = new BreathingActivity(2, "Start", "End", "desc", DateTime.Now, "instructions"
);

        // Activity activity = new Activity



        Console.WriteLine(tryBreathingActivity.Instruct());
        tryBreathingActivity.SetDuration();

        tryBreathingActivity.Spinner();
        tryBreathingActivity.StartTime();

        tryBreathingActivity.Tick();
        tryBreathingActivity.TimerEnded();

        tryBreathingActivity.Instruct();

        //-----------------------------------------

        ReflectingAactivity tryReflectingAactivity = new ReflectingAactivity(2, "Start", "End", "desc", DateTime.Now, "prompt", "intructions");


        tryReflectingAactivity.SetDuration();
        tryReflectingAactivity.Spinner();
        tryReflectingAactivity.StartTime();
        tryReflectingAactivity.Tick();
        tryReflectingAactivity.TimerEnded();

        tryReflectingAactivity.GetPrompt();
        tryReflectingAactivity.GetQuestion();

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

        tryListingActivity.SetDuration();
        tryListingActivity.Spinner();
        tryListingActivity.StartTime();
        tryListingActivity.Tick();
        tryListingActivity.TimerEnded();

        tryListingActivity.DistplayList();



    }
}