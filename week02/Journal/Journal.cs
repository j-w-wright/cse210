using System;
using StreamWriter = System.IO.StreamWriter;
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
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._promptText);
            Console.WriteLine(entry._entryText);
            Console.WriteLine("-------------------------------");
        }
    }
    public void SaveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {

    }
}
