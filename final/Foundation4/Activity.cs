public class Activity
{
    protected string _date;
    protected int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0.00;
    }

    public virtual double GetSpeed()
    {
        return 0.00;
    }

    public virtual double GetPace()
    {
        return 0.00;
    }

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}