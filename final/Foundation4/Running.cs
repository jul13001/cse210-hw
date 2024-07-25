using System;

public class Running : Activity
{
    private int _distance{get; set;}

    public Running(string date, int lengthActivity, int distance): base (date, lengthActivity)
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance()/ lengthActivity) * 60;
        return speed;
    }

    public override double GetPace()
    {
        return lengthActivity / _distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}-Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }

}