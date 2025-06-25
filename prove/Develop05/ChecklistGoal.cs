public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int userScore, int basePoints, bool isDone, int timesCompleted, int targetCount, int bonusPoints)
    : base(name, description, userScore, basePoints, isDone)
    {
        _timesCompleted = timesCompleted;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }
    protected override void recordEvent()
    {
        throw new NotImplementedException();
    }

    protected override int getScore()
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
}