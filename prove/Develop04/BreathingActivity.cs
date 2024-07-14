using System;
using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration): base (name, description, duration)
    {

    }
    public void Run()
    {
        {
            ShowSpinner(3);
            Console.WriteLine("Breath in...");
            ShowCountDown(3);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(3);

        }
    }
}