using System;
using System.Runtime.CompilerServices;

// using System.Runtime.CompilerServices;
using System.Threading;
class Program

// 1/10
{
    static void Main(string[] args)
    {

        
        CheckListGoal  listGoal = new CheckListGoal ("", "", 1, false, 0, 0, 0); 
        EternalGoal foreverGoal = new EternalGoal("Exercise", "Run daily", 5, false, 0);
        SimpleGoal simpleGoal = new SimpleGoal("Read Book", "Read 10 pages", 10, false);
        Goals goals = new Goals();
        Menu GoalMenu = new Menu();

    int choice = 0;
        void CreateGoal()
            {
                switch (choice)
                {
                    case 1:

                        simpleGoal.RunGoal();
                        goals.AddGoal(simpleGoal);

                        break;
                    case 2:
                        foreverGoal.RunGoal();
                        break;
                    case 3:
                        listGoal.RunGoal();
                        break;
                }
            }

        
        while (choice != 6)
        {
            choice = GoalMenu.displayMenu();
            switch (choice)
            {
                case 1:
                    GoalMenu.CreateGoalMenu();
                    CreateGoal();
                    break;
                // Add other cases as needed
                case 2:
                    goals.DisplayGoals();

                    break;
                case 3:
                    goals.SaveGoals();
                    break;
                case 4:
                    goals.LoadGoal(); 
                    break;
                case 5:
                    // RecordEvent()
                    break;

            }
        
        }
        // Console.WriteLine("Hello Develop05 World!");

        // int sleepTime = 250;

        // DateTime currentTime = DateTime.Now;
        // DateTime endTime = currentTime.AddSeconds(20);

        // string animationString = "(^_^) (-_-)";

        // string animationString2 = "-+\\/-|/";
        // int index = 0;
        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(animationString2[index++ % animationString2.Length]);
        //     // % in this case keeps the loop going 0-4
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");

        //     // if two digit time then add an if with another \b
        // }

        // int time = 9;
        // int count = time;

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(count--);
        //     Thread.Sleep(1000);
        //     Console.Write("\b");

        //     // if two digit time then add an if with another \b
        // }


        // while (DateTime.Now < endTime)
        // {

        //     Console.Write(animationString[0..5]);
        //     Thread.Sleep(500);
        //     Console.WriteLine(" . ");
        //     Console.Write("+");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        //     Console.Write(animationString);
        //     Console.Write("-");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }
    }
}