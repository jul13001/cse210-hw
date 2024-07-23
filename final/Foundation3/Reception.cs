using System;
using System.ComponentModel;
using System.Reflection;

public class Reception : Event
{
    public string _rsvpEmail {get;set;}

    public Reception(string eventTitle, string description, string date, string time, Address address, string rsvpEmail) : base(eventTitle,description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{DisplayStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}