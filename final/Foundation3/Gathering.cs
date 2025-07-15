public class Gathering : Event{

    private string _forecast;

    public Gathering(string title, string description, DateTime date, DateTime time, Address address, string rsvp) 
    :base(title, description, date, time, address){
        _rsvp = rsvp;
    }

    protected string GetFullDescription(){
        return $"{GetStandardDescription()} \nToday's forecast is {_forecast}.";
    }

}