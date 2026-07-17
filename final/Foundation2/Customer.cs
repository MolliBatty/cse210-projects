using System;

class Customer
{
    private string _cname;
    private Address _address;

    public Customer(string cname, Address address)
    {
        _cname = cname;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetCname()
    {
        return _cname;
    }
    public Address GetAddress()
    {
        return _address;
    }
}