using System;

public class Scripture
{
    private Reference _reference;

    private List<PresentWord> _words = new List<PresentWord>();

    public ScriptureText(Reference reference, string text);

    private void HideRandomWords()
    {
    }

    private string GetDisplayText()
    {
        return "";
    }

    private bool IsCompletelyHidden()
    {
        return true;
    }
}