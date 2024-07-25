using System;

public class Biking : Activity
{
    private int _speed{get; set;}

    public Biking(string date, int lengthActivity, int speed): base(date, lengthActivity)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = lengthActivity * _speed / 60;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return lengthActivity/ GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}-Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}