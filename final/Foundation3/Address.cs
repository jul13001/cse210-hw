using System;
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public Address(string street, string city, string state, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public string street { get { return _street; } }
    public string city { get { return _city; } }
    public string state { get { return _state; } }

    public string zipCode{ get {return _zipCode;}}

    public override string ToString()
    {
        return $"{street},{city},{state},{zipCode}";
    }
}