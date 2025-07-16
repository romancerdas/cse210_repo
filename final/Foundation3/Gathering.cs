public class Gathering : Event{

    private string _forecast;

    public Gathering(string title, string description, DateTime dateTime, Address address, string forecast) 
    :base(title, description, dateTime, address){
        _forecast = forecast;
    }

    public string GetFullDescription(){
        return $"{GetStandardDescription()} \nToday's forecast is {_forecast}.";
    }

}