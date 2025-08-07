using System;

public class Scripture
{
    private Reference _reference;
    private Random _random = new Random();
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] separatedWords = text.Split(" ");
        foreach (string word in separatedWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int wordsAvailable = _words.Count(w => !w.IsHidden());
        int wordsToHide = Math.Min(numberToHide, wordsAvailable);

        int hidden = 0;
        while (hidden < wordsToHide)
        {
            int index = _random.Next(_words.Count());
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    public string GetScriptureText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetReference()} {GetScriptureText()}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}