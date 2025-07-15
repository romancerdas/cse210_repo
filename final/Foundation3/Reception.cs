public class Reception : Event{
    private string _rsvp;


    public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvp)
    :base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }  

    protected string GetFullDescription(){
        return $"{GetStandardDescription()} \nPlease RSVP at rsvp@here.com"
    }
    

}