public class Journal 
{
    public List<Entry> _entries;

    public void AddEntry (Entry newEntry)
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
        // Save the journal entry to a file
    }
    public void LoadFromFile(string file)
    {
        // Load the journal entries from a file
    }
}