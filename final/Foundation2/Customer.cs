public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }
    public string customerName { get { return _customerName; } }
    public Address Address {get { return _address;}}
    public bool IsUsa()
    {
        if (_address.country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}