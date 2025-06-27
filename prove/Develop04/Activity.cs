using System.Runtime;

abstract class Activity
{
    private int _duration;
    private string _startingMessage;
    private string _endingMessage;
    private string _descrbition;

    private DateTime _EndTime;

    //--------------------------------------
    public Activity(int _duration, string _startingMessage, string _endingMessage, string _descrbition, DateTime _EndTime)
    {
        int Duration = _duration;
        string StartingMessage = _startingMessage;
        string EndingMessage = _endingMessage;
        string descrbition = _descrbition;
        DateTime EndTime = _EndTime;


    }


    public DateTime Timer(DateTime endtime, int duration)
    {
        return DateTime.Now;
    }

    // if time left is greater then zero then count down
    public void Tick()
    {
        if (_duration >= 0)
        {
            _duration--;
        }

    }


    // returns false if duration hits zero
    public bool TimerEnded()
    {
        return _duration <= 0;
    }

    public int StartTime()
    {
        return _duration;
    }


    public void SetDuration()
    {
        Console.WriteLine("How long in secounds would you like your activity to last?");
        _duration = int.Parse(Console.ReadLine());

        //     Console.WriteLine("How long in seconds would you like your activity to last?");
        // string input = Console.ReadLine();
        // int duration;
        // while (!int.TryParse(input, out duration) || duration <= 0)
        // {
        //     Console.WriteLine("Please enter a valid positive number for duration:");
        //     input = Console.ReadLine();
        // }
        // _duration = duration;
    }

    public void Spinner()
    {
        int sleepTime = 250;

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        string animationString = "\\/|\\/";
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            // % in this case keeps the loop going 0-4
            Thread.Sleep(sleepTime);
            Console.Write("\b");

            // if two digit time then add an if with another \b
        }

    }

    abstract public void Run();
   

}


   

 

   


