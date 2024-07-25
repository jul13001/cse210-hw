using System;
using System.Security.Cryptography;

public abstract class Activity
{
    private string _date;
    private int _lengthActivity;

    public Activity(string date, int lengthActivity)
    {
        _date = date;
        _lengthActivity = lengthActivity;
    }
    public string date { get { return _date; } }
    public int lengthActivity { get { return _lengthActivity; } }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date} {GetType().Name} ({lengthActivity} min)";
    }

}