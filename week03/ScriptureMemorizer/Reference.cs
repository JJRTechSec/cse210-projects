using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    //private Reference(string book, int chapter, int startVerse, int endVerse)

    public string GetReference()
    {
        return $"{_book}, {_chapter}, {_verse}";
    }

    public string GetDisplayText()
    {
        return "";
    }
}