using System;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words = new List<Word>();

    public Scripture(string text)
    {
        //_reference = reference;
        _text = text;
        string separatedWords =_text.Split(" ").ToString();
        Console.WriteLine(separatedWords);
    }

    public void HideRandomWords()
    {
    }

    public string GetScriptureText()
    {
        return _text;
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