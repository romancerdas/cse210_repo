using System.ComponentModel;
using System.Data.Common;
using System.Dynamic;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _basePoints;
    private bool _isDone;

    public Goal(string name, string description, int basePoints, bool isDone)
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
        _isDone = isDone;
    }

    public abstract void recordEvent();
    public abstract string getStringForm();

    public abstract string getDisplayString();


    protected void setName()
    {
        Console.WriteLine("What is your goal?");
        _name = Console.ReadLine();
    }
    public string getName()
    {
        return _name;
    }

    protected void setDescription()
    {
        Console.WriteLine("Give a short description of the goal:");
        _description = Console.ReadLine();

    }
    public string getDescription()
    {
        return _description;
    }

    protected void setPoints()
    {
        Console.WriteLine("How many points do you want for completing this goal? ");
        _basePoints = int.Parse(Console.ReadLine());
        // return points;
    }
    public int getPoints()
    {
        return _basePoints;
    }

    protected void setisDone()
    {
        this._isDone = true;
    }
    public bool getisDone()
    {
        return _isDone;
    }
}