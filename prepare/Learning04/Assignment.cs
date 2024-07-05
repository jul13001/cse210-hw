using System;

public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studentname, string topic)
    {
        _studentName = studentname;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} topic: {_topic}";
    }
    public string GetStudentName()
    {
        return _studentName;
    }
}