using System;

public class Swimming : Activity
{
   private int _numberLaps{get; set;}

   public Swimming(string date, int lengthActivity, int numberLaps): base(date, lengthActivity)
   {
    _numberLaps = numberLaps;
   }
    public override double GetDistance()
    {
        double distance = _numberLaps * 50/1000 * 0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance()/lengthActivity) * 60;
    }

    public override double GetPace()
    {
        return 60/GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}-Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}