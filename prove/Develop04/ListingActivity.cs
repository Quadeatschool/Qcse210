 class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who have you helped this week?",
    "What moments made you happy recently?",
    "Who are some of your personal heroes?"
};

    //-------------------------------

    public ListingActivity(int duration,
        string startingMessage,
        string endingMessage,
        string description,
        List<string> prompts ) : base(duration, startingMessage, endingMessage, description)
    {
        _prompts = prompts;
    }

    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public override void Run()
    {

        DisplayStartMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}\n");

        Console.WriteLine("You will have a few seconds to think, then start listing . . .");
        Countdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int count = 0;

        List<string> userEntries = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item");
            string userInput = Console.ReadLine();

            if ((!string.IsNullOrWhiteSpace(userInput)))
            {
                userEntries.Add(userInput);
                count++;
            }

        }
        Console.WriteLine($"\nYou listed {count} items.");

        DisplayEndMessage();

    }
} 