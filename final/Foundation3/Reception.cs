public class Reception : Event{
    private string _rsvp;


    public Reception(string title, string description, DateTime dateTime, Address address, string rsvp)
    :base(title, description, dateTime, address)
    {
        _rsvp = rsvp;
    }  

    public string GetFullDescription(){
        return $"{GetStandardDescription()} \nPlease RSVP at rsvp@here.com";
    }
    

}