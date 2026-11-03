using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private const string Separator = "~|~";

    // Adds a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Displays all journal entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves all journal entries to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry._date}{Separator}{entry._prompt}{Separator}{entry._response}{Separator}{entry._mood}"
                );
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    // Loads journal entries from a file
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Your journal was not changed.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(
                new string[] { Separator },
                StringSplitOptions.None
            );

            if (parts.Length == 4)
            {
                Entry entry = new Entry();

                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];
                entry._mood = parts[3];

                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }

    // Returns the total number of journal entries
    public int GetEntryCount()
    {
        return _entries.Count;
    }
}