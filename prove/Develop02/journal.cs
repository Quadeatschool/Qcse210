using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
        Console.WriteLine($"Entry added. Total entries: {_entries.Count}");
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.\n");
            return;
        }
        foreach (var entry in _entries)
        {
            Console.WriteLine("------");
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            Console.WriteLine($"Saving {_entries.Count} entries...");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine(entry.ToCsv());
                }
            }
            Console.WriteLine($"Journal saved to {Path.GetFullPath(filename)}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {

        _entries.Clear(); // prevents duplicates when loading
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        foreach (var line in File.ReadAllLines(filename))
        {
            var entry = JournalEntry.FromCsv(line);
            if (entry != null)
                _entries.Add(entry);
        }
        Console.WriteLine($"Journal loaded from {filename}\n");
    }


    // Creativity: Counts the number of entries in the journal
    public void CountEntries()
    {
        Console.WriteLine($"Total entries in journal: {_entries.Count}\n");
    }
    

}