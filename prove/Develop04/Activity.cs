class Activity
{
    string _name;
    string _description;
    int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    protected void startMessage() {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void endMessage()
    {
        Console.WriteLine("Well Done!");
        Console.Write($"You have completed {_duration} seconds of the {_name}.");
    }
}