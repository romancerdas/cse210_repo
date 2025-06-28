public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int basePoints, bool isDone)
    : base(name, description, basePoints, isDone) { }

    public override void recordEvent()
    {
        Console.WriteLine($"You made progress on '{this.getName()}' and earned {this.getPoints()} points!");
    }

    public void CreateNewEternalGoal()
    {
        setName();
        setDescription();
        setPoints();
    }

    public override string getDisplayString()
    {
        string checkbox = this.getisDone() ? "[X]" : "[ ]";
        return $" {checkbox} {this.getName()} ({this.getDescription()})";
    }

    public override string getStringForm()
    {
        return $"EternalGoal:{this.getName()},{this.getDescription()},{this.getPoints()}";
    }

}