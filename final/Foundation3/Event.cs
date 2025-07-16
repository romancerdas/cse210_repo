public class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address){
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    public string GetStandardDescription(){
        return $"Title: {_title} \nDescription: {_description} \nDate: {_dateTime} \nAddress: {_address.DisplayFullAddress()}";
    }

    public string GetShortDescription(){
        return $"Event Type: {this.GetType().Name} \nTitle: {_title} \nDate: {_dateTime}";
    }
}