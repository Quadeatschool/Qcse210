using System;

public class Questions
{
    public string[] _questions = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I most grateful for today?",
        "What made me smile today?",
        "What positive change can I make in my life?",
        "What am I looking forward to tomorrow?",
        "What is something I want to let go of?"
    };

    public string NextQuestion()
    {
        Random prompt = new Random();
        int index = prompt.Next(_questions.Length);
        return _questions[index];
    }
}