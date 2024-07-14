using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a moment today when you felt truly present.",
        "Reflect on a time when you felt deeply connected with nature",
        "Consider a time when you listened to someone without judgment. ",
        "Recall a moment when you felt grateful. ",
        "Think of a time when you practiced self-compassion.",
        "Reflect on a recent experience where you felt a strong emotion.",
    };
    private List<string> _questions = new List<string>
    {
        "How did this make you feel?",
        "How can you grow from this experience?",
        "What message can you take away from this?",
        "How would you explain this to a freind or family member?",
    };

    public ReflectingActivity(string name, string description, int duration): base (name, description, duration)
    {

    }
    public void Run()
   {
        Console.Clear();
        ShowSpinner(5);

        string prompt = GetRandomPrompt();
        string question = GetRandomQuestion();

        DisplayPrompt(prompt);
        DisplayQuestions(question);
    }

    private Random _rand = new Random();
    public string GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Consider this prompt: {prompt}");
        Thread.Sleep(1000);
        ShowSpinner(5);
    }
    public void DisplayQuestions(string question)
    {
        
        Console.WriteLine($" {question}");
        Thread.Sleep(1000);
        ShowSpinner(5);
    }
}