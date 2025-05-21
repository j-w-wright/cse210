public class Scripture
{
    private string _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>();
        InitializeWords();
    }

    private void InitializeWords()
    {
        string[] wordArray = _text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}: {string.Join(" ", _words)}");
    }
}