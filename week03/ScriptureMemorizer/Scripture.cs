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
    }

    public string GetScriptureText()
    {
        return "";
    }

    public string GetDisplayText()
    {
        return $"{_reference}";
    }

    private bool IsCompletelyHidden()
    {
        return true;
    }
}