 class ListingActivity : Activity
{
    private List<string> _listItems;

    //-------------------------------

    public ListingActivity(int duration,
        string startingMessage,
        string endingMessage,
        string description,
        DateTime endTime,
        List<string> listItems) : base(duration, startingMessage, endingMessage, description, endTime)
    {
        List<string> _listItems = listItems;
    }

    public void DistplayList()
    {
        Console.WriteLine($"{_listItems}");
    }


    public override void Run()
    {
        SetDuration();
        Spinner();
        StartTime();
        Tick();
        DistplayList();

    }
} 