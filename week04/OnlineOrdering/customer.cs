public class Customer
{
    public string _cutomerName;
    public Address _customerAddress;

    public Customer(string name, Address address)
    {
        _cutomerName = name;
        _customerAddress = address;

    }

    public string GetName()
    {
        return _cutomerName;
    }

    public bool LivesInUSA()
    {
        return _customerAddress.addressIsUsa();
    }

    public string GetAddressLabel()
    {
        return $"{_cutomerName}\n{_customerAddress.GetFullAddress()}";
    }
}


