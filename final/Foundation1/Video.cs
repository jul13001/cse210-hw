using System;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();
    public void Display()
    {
        Console.WriteLine($"Author: {_author} Title: {_title} Length:{_length} minute");

        foreach (Comment comment in _comments)
        {
            comment.DisplayVideoDetails();

        }
    }


}