using System;
using System.Security.Cryptography.X509Certificates;

public abstract class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
    _eventTitle = eventTitle;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
    }
    public string eventTitle { get { return _eventTitle; } }
    public string description { get { return _description; } }
    public string date { get { return _date; } }

    public string time{ get {return _time;}}

    public string DisplayStandardDetails()
    {
        return $"{_eventTitle}, {_description}, {_date}, {_time}, {_address}";

    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {eventTitle}\nDate:{date}";
    }
 
}