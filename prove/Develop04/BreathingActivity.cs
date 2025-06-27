class BreathingActivity : Activity
{
    private string _instructions;
    //-------------------------------------------
    public BreathingActivity(int duration,
        string startingMessage,
        string endingMessage,
        string description,
        DateTime endTime,
        string instructions
    ) : base(duration, startingMessage, endingMessage, description, endTime)
    {
        _instructions = instructions;
    }

    public string Instruct()
    {
        return _instructions;
    }

    public override void Run()
    {
         Console.WriteLine(Instruct());
      SetDuration();

        Spinner();
        StartTime();
        Tick();
        TimerEnded();
        Instruct();
    }
    

}