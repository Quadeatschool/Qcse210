using System.Dynamic;

class ReflectingAactivity : Activity
{
    private string _prompt;
    private string _questions;

    //--------------------------

    public ReflectingAactivity(int duration,
        string startingMessage,
        string endingMessage,
        string description,
        DateTime endTime,
        string prompt,
        string questions)
     : base(duration, startingMessage, endingMessage, description, endTime)
    {
        string _prompt = prompt;
        string _questions = questions;

    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetQuestion()
    {
        return _questions;
    }

    public override void Run()
    {

        
        SetDuration();
        Spinner();
        StartTime();
        Tick();
        
        GetPrompt();
        GetQuestion();

    }

}