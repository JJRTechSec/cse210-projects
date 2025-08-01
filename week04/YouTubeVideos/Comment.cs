using System;

public class Comment
{
    private string _commenterName;
    private string _commentText;

    public string SetCommenterName(string name)
    {
        _commenterName = name;
        return _commenterName;
    }

    public string SetCommentText(string text)
    {
        _commentText = text;
        return _commentText;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"{_commenterName} - '{_commentText}'");
    }
}