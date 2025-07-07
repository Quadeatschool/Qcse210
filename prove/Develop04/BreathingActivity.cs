using System.Threading.Tasks.Dataflow;

class BreathingActivity : Activity
{
    private string[] _instructions;

    public BreathingActivity(int duration,
        string startingMessage,
        string endingMessage,
        string description,
        DateTime endTime,
        string instructions // Pass as "Breathe in...|Breathe out..."
    ) : base(duration, startingMessage, endingMessage, description, endTime)
    {
        // Split the instructions string into an array
        _instructions = instructions.Split('|');
    }

    public string Instruct(int phase)
    {
        // phase: 0 for in, 1 for out
        return _instructions[phase % _instructions.Length];
    }

    public void BreathTimer(int cycles = 3)
    {
        int sleepTime = 1000;
        string animationString = "4321";

        for (int i = 0; i < cycles * 2; i++)
        {
            Console.WriteLine(Instruct(i % 2));
            foreach (char character in animationString)
            {
                Console.Write(character);
                Thread.Sleep(sleepTime);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    }

    public override void Run()
    {
        Console.WriteLine(GetStartingMessage());
        Console.WriteLine(GetDescription());
        SetDuration();
        StartTime();
        Spinner();
        BreathTimer();
        TimerEnded();
    }
}