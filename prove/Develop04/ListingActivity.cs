using System;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity(string name, string description, int duration): base(name, description, duration)
    {
    }
    List<string> _entries = new List<string>();
    public void Run()
    {
        Console.WriteLine("Get Ready..");
        ShowSpinner(5);
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);

        GetListFromUser();

        Console.WriteLine($"You have entered {_entries.Count} items.");

    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Consider this prompt: {prompt}");
        ShowSpinner(5);
    }
    public void GetListFromUser()
    {
        for (int i = 0; i < _count; i++)
        {
            Console.WriteLine("Enter an item: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                _entries.Add(input);
            }
        }
    }
}