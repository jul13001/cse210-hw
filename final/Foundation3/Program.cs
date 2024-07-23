using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("567 Wolffe St", "Memphis", "TN", "13542" );
        Outdoor outdoor = new Outdoor("Picnic class of 2013", "Join us for a class reunion in a picnic at the park", "January 16", " 2:00 PM", address1, "Partly Cloudy");

        Address address2 = new Address("78 Randolph Ave", "Harrisonburg", "VA", "67890");
        Lecture lecture = new Lecture("Robert Free", 50, "Public Speaker", "Join us for an educational lecture on how to speak publicly", "February 13", "5:00 PM", address2);

        Address address3 = new Address("5842 Marlowe Street", "Jacksonville", "FL", "85402");
        Reception reception = new Reception("Amy & John Wedding Reception", "Join us for Amy and John's special day and celebrate their wedding", "January 1st", "5:00 PM", address3, "tyson@gmail.com");

        Console.WriteLine(outdoor.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine(lecture.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine(reception.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());





    }
}