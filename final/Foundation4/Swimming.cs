public class Swimming : Activity
{
    private double _laps;


    public Swimming(string date, int duration, double laps)
    : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _duration) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    // public override string GetSummary()
    // {
    //     return "";
    // }
}