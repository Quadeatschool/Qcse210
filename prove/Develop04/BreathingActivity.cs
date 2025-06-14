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
       string _instructions = instructions;
    }

    public string Instruct(string instructions)
    {
        return instructions; 
    }

    
}