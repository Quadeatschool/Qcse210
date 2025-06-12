using System.Dynamic;

public class ReflectingAactivity : Activity
{
    private string _prompt;
    private string _questions;

    //--------------------------

    public ReflectingAactivity(int time)
     : base(time, "", "", "", DateTime.Now)
    {

    }

    public string GetPrompt(string prompt)
    {
        return prompt;
    }
}