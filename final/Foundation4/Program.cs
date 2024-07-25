using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("04 January 2024", 30, 3));
        activities.Add(new Biking("09 September 2023", 50, 4));
        activities.Add(new Swimming("05 May 2024", 45, 50));

        activities.Add(new Running("10 February 2024", 50, 15));
        activities.Add(new Biking("21 November 2022", 90, 7));
        activities.Add(new Swimming("16 April 2024", 70, 120));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}