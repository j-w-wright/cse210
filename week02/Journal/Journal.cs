public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        // Open the file for writing
        using (StreamWriter writer = new StreamWriter(file))
        {
            // Write each entry to the file
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
                writer.WriteLine();
            }
        }
    }
    public void LoadFromFile(string file)
    {
        // Open the file for reading
        using (StreamReader reader = new StreamReader(file))
        {
            // Read each entry from the file
            while (!reader.EndOfStream)
            {
                Entry entry = new Entry();
                entry._date = reader.ReadLine();
                entry._promptText = reader.ReadLine();
                entry._entryText = reader.ReadLine();
                _entries.Add(entry);
            }
        }
    }
}