class BreathingActivity : Activity
{
    private string[] _instructions;

    public BreathingActivity(int duration,
        string startingMessage,
        string endingMessage,
        string description,
        string instructions // Pass as "Breathe in...|Breathe out..."
    ) : base(duration, startingMessage, endingMessage, description)
    {
        // Split the instructions string into an array
        _instructions = instructions.Split('|');
    }

    public string Instruct(int phase)
    {
        // phase: 0 for in, 1 for out
        return _instructions[phase % _instructions.Length];
    }

    public void BreathTimer()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        int phase = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_instructions[phase % _instructions.Length]);

            Countdown(4);

            phase++;
        }
    }

    public override void Run()
    {

        
        DisplayStartMessage();

        BreathTimer(); // The is what will run the breathing part of the activity 

        DisplayEndMessage();

    }
}