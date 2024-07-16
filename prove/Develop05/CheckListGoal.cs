using System;
using System.ComponentModel;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }



    public override void RecordEvent()
    {
        Console.Write("Enter amount completed: ");
        int amount = int.Parse(Console.ReadLine());
        _amountCompleted += amount;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public string GetDetailString()
    {
        return $"Target: {_target}, Completed: {_amountCompleted}, Bonus: {_bonus}";
    }
    public override string GetStringRepresentation()
    {
        return $"[{(IsComplete() ? "x" : " ")}] Simple Goal: {_shortName}, {_description}, Points: {_points} Completed {_amountCompleted}/ {_target}";
    }
}