using System;
using System.IO;

public class JournalEntry
{
    private DateTime _date;
    private string _prompt;
    private string _response;

    public JournalEntry(DateTime date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()}\nPrompt: {_prompt}\nResponse: {_response}\n");
    }

    public string ToCsv()
    {
        return $"{_date:o}|{_prompt.Replace("|", "/")}|{_response.Replace("|", "/")}";
    }

    public static JournalEntry FromCsv(string csv)
    {
        var parts = csv.Split('|');
        if (parts.Length != 3) return null;
        if (!DateTime.TryParse(parts[0], out DateTime date)) return null;
        return new JournalEntry(date, parts[1], parts[2]);
    }

    public void Save(string filePath)
    {
        File.AppendAllText(filePath, ToCsv() + Environment.NewLine);
        Console.WriteLine($"Journal saved to {Path.GetFullPath(filePath)}\n");
    }

}
