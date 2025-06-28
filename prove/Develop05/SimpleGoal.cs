using System.Dynamic;

public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int basePoints, bool isDone)
    : base(name, description, basePoints, isDone)
    {
    }

    public override void recordEvent()
    {
        if (this.getisDone() != true)
        {
            this.setisDone();
            Console.WriteLine($"You earned {getPoints()} points!");
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }

    }
    
    public void CreateNewSimpleGoal()
    {
        setName();
        setDescription();
        setPoints();
    }

    public override string getStringForm()
    {
        return $"SimpleGoal:{getName()},{getDescription()},{getPoints()},{getisDone()}";
    }

    public override string getDisplayString()
    {
        // line 49 uses a ternary operator, which checks the isDone status, then uses the string according to the status 
        string checkbox = this.getisDone() ? "[X]" : "[ ]";
        return $"{checkbox} {getName()} ({getDescription()})";
    }
}