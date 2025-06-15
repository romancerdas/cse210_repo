class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }

    protected void startMessage() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Animation animation = new Animation();
        animation.runAnimation(3);
    }

    protected void endMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        Animation animation = new Animation();
        animation.runAnimation(3);
        Console.Clear();
    }

    protected int getDuration() {
        return _duration;
    }
}