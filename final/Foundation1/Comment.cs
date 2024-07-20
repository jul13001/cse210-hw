using System;
using System.Diagnostics.Contracts;

public class Comment
{
    public string _commentor;
    public string _commentText;

    public Comment(string commentor, string commentText)
    {
        _commentor = commentor;
        _commentText = commentText;
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"{_commentor} Commented: {_commentText}");
    }
}