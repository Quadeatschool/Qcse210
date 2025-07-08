using System;

public class JournalEntry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public JournalEntry(string prompt, string response)
    {
        Date = DateTime.Now;
        Prompt = prompt;
        Response = response;
    }

    public JournalEntry(DateTime date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date.ToShortDateString()}\nPrompt: {Prompt}\nResponse: {Response}\n");
    }

    public string ToCsv()
    {
        return $"{Date.ToString("o")}|{Prompt.Replace("|", "/")}|{Response.Replace("|", "/")}";
    }

    public static JournalEntry FromCsv(string csv)
    {
        var parts = csv.Split('|');
        if (parts.Length != 3) return null;
        if (!DateTime.TryParse(parts[0], out DateTime date)) return null;
        return new JournalEntry(date, parts[1], parts[2]);
    }
}
