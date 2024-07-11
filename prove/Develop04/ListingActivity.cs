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

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts): base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {

    }
    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
    }

    public void GetListFromUser()
    {
        for (int i = 0; i < _count; i++)
        {
            Console.WriteLine("Enter an item: ");
            string input = Console.ReadLine();
        }
    }
}