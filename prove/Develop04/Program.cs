using System;

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

    }
}