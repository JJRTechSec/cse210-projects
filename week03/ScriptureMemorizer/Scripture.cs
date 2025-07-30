using System;

public class Scripture
{
    private Reference _reference;
    private string _text;

    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public void HideRandomWords()
    {
    }

    public string GetDisplayText()
    {
        return $"{_reference}, {_text}";
    }

    private bool IsCompletelyHidden()
    {
        return true;
    }
}