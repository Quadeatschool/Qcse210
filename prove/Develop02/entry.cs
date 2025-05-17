public class JournalEntry
{

    string _date;
    string _prompt;
    string _response;

    public void Entry(string date, string prompt, string response)
    {

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
