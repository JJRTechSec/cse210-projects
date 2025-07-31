using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    private void Hide()
    {
        Console.WriteLine();
    }

    private void Show()
    {
        Console.WriteLine();
    }

    //private bool IsHidden()

    public string GetDisplayText()
    {
        return _text;
    }

}