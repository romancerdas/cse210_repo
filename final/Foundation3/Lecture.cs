public class Lecture : Event{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity) 
    : base(title, description, dateTime, address){
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDescription(){
        return $"{GetStandardDescription()} \nSpeaker: {_speaker} \nCapacity: {_capacity}";
    }
}
