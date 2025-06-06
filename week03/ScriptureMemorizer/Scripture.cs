using System;
using System.Security.Cryptography.X509Certificates;

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
        // Get indexes of unhidden words
        List<int> unhiddenIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                unhiddenIndexes.Add(i);
        }
        int wordsToHide = Math.Min(numberOfWords, unhiddenIndexes.Count);
        while (count < wordsToHide && unhiddenIndexes.Count > 0)
        {
            int randIdx = random.Next(unhiddenIndexes.Count);
            int wordIdx = unhiddenIndexes[randIdx];
            _words[wordIdx].Hide();
            unhiddenIndexes.RemoveAt(randIdx);
            count++;
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