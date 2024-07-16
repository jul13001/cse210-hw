using System;
using System.ComponentModel;

public abstract class Goal
{
    public string _shortName { get; set; }
    public string _description { get; set; }
    public int _points { get; set; }

    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public void SetName(string name)
    {
        _shortName = name;
    }

    public string GetDesciption()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        return $"[ ] {_shortName}, {_description}";
    }
    public abstract string GetStringRepresentation();

}