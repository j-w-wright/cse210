using System.Runtime.CompilerServices;

public class Scripture
{
    private string _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();  
        string[] wordArray = text.Split(' '); // Split the text into words
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word)); // Create a new Word object for each word
        }
    }

    public void HideRandomWords(int numberOfWords)
    {
        Random random = new Random();
        int count = 0;

        while (count < numberOfWords)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference + "\n";
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                displayText += "____ ";
            }
            else
            {
                displayText += word.GetDisplayText() + " ";
            }
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}