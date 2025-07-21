using System;
using System.Threading;

abstract class Activity
{
    private int _duration;
    private string _startingMessage;
    private string _endingMessage;
    private string _descrbition;

    // private DateTime _endTime;

    //--------------------------------------
    public Activity(int duration, string startingMessage, string endingMessage, string descrbition)
    {
        _duration = duration;
        _startingMessage = startingMessage;
        _endingMessage = endingMessage;
        _descrbition = descrbition;
        // _endTime = endTime;
    }

    //--------------------------------------
    public int GetDuration() => _duration;

    public int SetDuration(int duration)
    {
        if (duration > 0)
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Duration must be a positive number.");
        }
        return _duration;
    }

    public string GetStartingMessage() => _startingMessage;

    public string GetEndingMessage() => _endingMessage;

    public string GetDescription() => _descrbition;


    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting Activity: {_startingMessage}\n");
        Console.WriteLine($"{_descrbition}\n");

        Console.Write("How many seconds would you like to do this activity for? ");
        string input = Console.ReadLine();

        while (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid positive number for seconds: ");
            input = Console.ReadLine();
        }
        Console.WriteLine("\nGet ready to begin . . .");
        Spinner(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!\n");
        Spinner(2);
        Console.WriteLine($"You have completed {_startingMessage} for {_duration} seconds.");
        Spinner(3);
    }

    public void Spinner(int seconds)
    {
        string[] symbols = { "\\", "/", "|", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string symbol in symbols)
            {
                Console.Write(symbol);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine();
    }

    //--------------------------------------
    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
    }

    protected DateTime GetEndTime()
    {
        return DateTime.Now.AddSeconds(_duration);
    }
    abstract public void Run();
   

}


   

 

   


