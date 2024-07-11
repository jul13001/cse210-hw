using System;
using System.Diagnostics.Contracts;

public class ReflectingActivity() : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration): base (name, description, duration)
    {

    }
    public void Run()
    {
        DisplayStartingMessage
        GetRandomPrompt
        
    }

    public string GetRandomPrompt()
    {

    }

    public string GetRandomQuestion()
    {

    }

    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {
        
    }
}