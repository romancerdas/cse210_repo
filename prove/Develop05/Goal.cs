using System.ComponentModel;
using System.Dynamic;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _basePoints;
    protected bool _isDone;

    public Goal(string name, string description, int userScore, string basePoints, bool isDone)
    {
        _name = name;
        _description = description;
        _basePoints = int.Parse(basePoints);
        _isDone = isDone;
    }

    protected abstract void recordEvent();

    // protected abstract int getScore();

    protected abstract string getCompletionStatus();

    protected abstract void sendToFile();


    protected void setName()
    {
        Console.WriteLine("What is your goal?");
        string goalname = Console.ReadLine();
        goalname = _name;
        // return goalname;
    }
    protected void setDescription()
    {
        Console.WriteLine("Give a short description of the goal:");
        string desc = Console.ReadLine();
        desc = _description;
        // return desc;
    }

    protected void setPoints()
    {
        Console.WriteLine("How many points do you want for completing this goal? ");
        string points = Console.ReadLine();
        points = _basePoints.ToString();
        // return points;
    }


}