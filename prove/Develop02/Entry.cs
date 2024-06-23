using System;

public class Entry
{
    public DateTime Date{get; set;}
    public string _promptText{get; set;}
    public string _entryText{get; set;}

    public Entry(string prompt, string response)
    {
        _promptText = prompt;
        _entryText = response;
        Date = DateTime.Now;
    }

    public void Display()
    {
        Console.WriteLine($"{Date}: {_promptText} /n{_entryText}");
    }
}