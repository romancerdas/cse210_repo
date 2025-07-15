public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    public Event(string title, string description, DateTime date, DateTime time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    protected string GetStandardDescription(){
        return $"Title: {_title} \nDescription: {_description} \nDate: {_date} @ {_time} \nAddress: {_address}";
    }

    protected string GetShortDescription(){
        return $"Event Type: {this.GetType().Name} \nTitle: {_title} \nDate: {_date}";
    }
}