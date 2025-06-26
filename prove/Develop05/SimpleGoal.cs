public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, string basePoints, bool isDone)
    : base(name,description,basePoints,isDone)
    {
    }

    protected override void recordEvent()
    {
        throw new NotImplementedException();
    }

    protected override string getCompletionStatus()
    {
        throw new NotImplementedException();
    }

    protected override void sendToFile()
    {
        throw new NotImplementedException();
    }
        public void CreateNewSimpleGoal()
    {
        setName();
        setDescription();
        setPoints();
    }
}