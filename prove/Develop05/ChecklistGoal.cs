public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int userScore, string basePoints, bool isDone, int timesCompleted, int targetCount, int bonusPoints)
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

    protected void setTargetCount()
    {
        Console.WriteLine("How many times does this goal need to be completed for the bonus? ");
        int count = int.Parse(Console.ReadLine());
        count = _targetCount;
    }

    protected void setBonusPoints()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        int bonuspoints = int.Parse(Console.ReadLine());
        bonuspoints = _bonusPoints;
    }

    public void CreatNewChecklistGoal()
    {
        setName();
        setDescription();
        setPoints();
        setTargetCount();
        setBonusPoints();
    }
}