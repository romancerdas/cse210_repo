public abstract class Goal
{
    private string _name;
    private string _description;
    protected int _userScore;
    private int _basePoints;
    protected bool _isDone;

    public Goal(string name, string description, int userScore, int basePoints, bool isDone)
    {
        _name = name;
        _description = description;
        _userScore = userScore;
        _basePoints = basePoints;
        _isDone = isDone;
    }

    protected abstract void recordEvent();

    protected abstract int getScore();

    protected abstract string getCompletionStatus();

    protected abstract void sendToFile();


}