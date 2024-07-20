using System;
using System.Net.Sockets;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country { get; set; }


    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string streetAddress { get { return _streetAddress; } }
    public string city { get { return _city; } }
    public string state { get { return _state; } }
    public string country { get { return _country; } }

    public string GetAddress()
    {
        return $"The address is: {_streetAddress}; {_city}, {_state}, {_country}";
    }
}