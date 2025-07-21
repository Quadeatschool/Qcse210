using System.Dynamic;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
};

private List<string> _questions = new List<string>
{
    "Why was this experience meaningful to you?",
    "How did you feel when it was complete?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
};

    //--------------------------

    public ReflectingActivity(int duration,
        string startingMessage,
        string endingMessage,
        string description,
        List<string> prompts,
        List<string> questions)
     : base(duration, startingMessage, endingMessage, description)
    {
        _prompts = prompts;
        _questions = questions;
    }




    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public List<string> GetQuestions()
    {
        return _questions;
    }



    

    public override void Run()
    {   
        

        DisplayStartMessage();
        Console.Clear();
        Console.WriteLine("Consider the following prompt:\n ");
        Console.WriteLine("---Think of a time when you did something really difficult. ---\n");
        Console.WriteLine("When you have something in mind press Enter to continue...");
        Console.ReadLine(); // This waits for Enter and returns the input (empty string if just Enter)

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}\n");
        Spinner(3);


        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"\nQuestion: {question}");
            Spinner(4);
        }

        DisplayEndMessage();
    }




}