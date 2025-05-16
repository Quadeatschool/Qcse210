using System;

public class Questions
{
    public string[] _questions = new string[]
    {
        "What am I most grateful for today?",

        "What was a challenge I faced, and how did I handle it?",

        "What did I learn about myself today?",

        "What positive change can I make in my life?",

        "What am I looking forward to tomorrow?",

        "What made me smile today?",

        "What am I most proud of today?",

        "How can I make tomorrow even better?",

        "What is something I want to let go of?",

        "What am I most grateful for in my life?",
    };

    public string NextQuestion()
    {
        Random prompt = new Random();
        int index = prompt.Next(_questions.Length);
        return _questions[index];
    }
}