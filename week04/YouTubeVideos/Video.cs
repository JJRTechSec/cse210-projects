using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public List<Comment> comments = new List<Comment>();

    public int GetNumberOfComments()
    {
        int commentLength = comments.Count();
        return commentLength;
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"{_title}, {_author}, {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        foreach (Comment comment in comments)
        {
            comment.DisplayComments();
        }
    }
}