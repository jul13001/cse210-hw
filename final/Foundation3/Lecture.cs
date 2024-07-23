using System;

public class Lecture : Event
{
    public string _speaker {get; set;}
    public int _capacity{get; set; }

   public Lecture(string speaker, int capacity, string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
   {
    _speaker = speaker;
    _capacity = capacity;
   }

   public override string GetFullDetails()
   {
    return $"{DisplayStandardDetails()}\nTyoe: Lecture \nSpeaker: {_speaker}\nMax Capacity: {_capacity}";
   }
}