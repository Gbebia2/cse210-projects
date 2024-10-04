using System;
using System.Collections.Generic;
using System.IO;

// Added code to stop 'load from file' execution if the file doesn't exist

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"{entry._date} - {entry._prompt}");
            Console.WriteLine(entry._response);
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
        Console.WriteLine("Journal successfully saved.");
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist.");
            return; 
        }
        
        _entries.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[2], parts[1], parts[0]);
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Journal loaded successfully");
    }   
}