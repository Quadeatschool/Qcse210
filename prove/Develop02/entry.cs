public class JournalEntry
{

    public DateTime _date { get; private set; }
    private string _prompt { get; set; }
    string _response { get; set; }

    public void Entry(string prompt, string response)
    {
        _date = DateTime.Now;
        _prompt = prompt;
        _response = response;
    }

    public void Entry() {}
    public void Display()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}");
    }

    public void EntryToSting()
    {

    }
    public void CreateEntryWithPrompt(string prompt)
    {

    }

    public void CreateEntryWithData(string date, string prompt, string response)
    {

    }
}
