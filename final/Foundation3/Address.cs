public class Address
{
    private string _streetname;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetname, string city, string state, string country)
    {
        _streetname = streetname;
        _city = city;
        _state = state;
        _country = country;
    }
    public string DisplayFullAddress()
    {
        return $"{_streetname} \n{_city},{_state},{_country}";
    }
}