using System.IO.Pipes;

public class Bike : Activity
{
    private double _speed;

    public Bike(string date, int duration, double speed)
    : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return GetPace() * _duration;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    // public override string GetSummary()
    // {
    //     return "";
    // }
}