public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int userScore, int basePoints, bool isDone) 
    : base(name, description, userScore, basePoints, isDone)
    {
    }

    protected override void recordEvent()
    {
        throw new NotImplementedException();
    }

    protected override int getScore()
    {
        return _userScore;
    }

    protected override string getCompletionStatus()
    {
        throw new NotImplementedException();
    }

    protected override void sendToFile()
    {
        throw new NotImplementedException();
    }
}