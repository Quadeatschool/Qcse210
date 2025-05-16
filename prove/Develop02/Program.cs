using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Questions newQuestion = new Questions();
        string randomQuestion = newQuestion.NextQuestion();
        Console.WriteLine($"{randomQuestion}");
    }
}