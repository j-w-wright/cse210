using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine();
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._promptText);
            Console.WriteLine(entry._entryText);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
                outputFile.WriteLine("-------------------------------");
            }
        }
        Console.WriteLine($"Journal entries saved to {file}");
        Console.WriteLine();
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        for (int i = 0; i < lines.Length; i += 4)
        {
            if (i + 3 < lines.Length && lines[i + 3] == "-------------------------------")
            {
                Entry entry = new Entry();
                entry._date = lines[i];
                entry._promptText = lines[i + 1];
                entry._entryText = lines[i + 2];
                _entries.Add(entry);
            }
        }
        Console.WriteLine($"Journal entries loaded from {file}");
    }
}

