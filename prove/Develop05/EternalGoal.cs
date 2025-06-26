public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int userScore, string basePoints, bool isDone) : base(name, description, userScore, basePoints, isDone) { }

    protected override void recordEvent()
    {
        throw new NotImplementedException();
    }

    // protected override int getScore()
    // {
    //     throw new NotImplementedException();
    // }

    protected override string getCompletionStatus()
    {
        throw new NotImplementedException();
    }

    protected override void sendToFile()
    {
        throw new NotImplementedException();
    }

    public void CreateNewEternalGoal()
    {
        setName();
        setDescription();
        setPoints();
    }
}