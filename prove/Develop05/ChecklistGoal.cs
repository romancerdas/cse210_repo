using System.Collections.Specialized;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int basePoints, bool isDone, int bonusPoints, int targetCount, int timesCompleted)
    : base(name, description, basePoints, isDone)
    {
        _timesCompleted = timesCompleted;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }
    public override void recordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            Console.WriteLine($"You earned {getPoints()} points! Progress: ({_timesCompleted}/{_targetCount})");

            if (_timesCompleted == _targetCount)
            {
                this.setisDone();
                Console.WriteLine($"Good Work! You completed the checklist and earned a {_bonusPoints} point bonus!");
            }

            if (_timesCompleted >= _targetCount)
            {
                Console.WriteLine("This goal is already complete!");
            }
        }
    }

    protected void setTargetCount()
    {
        Console.WriteLine("How many times does this goal need to be completed for the bonus? ");
        int count = int.Parse(Console.ReadLine());
        _targetCount = count;
    }

    public int getTargetCount()
    {
        return _targetCount;
    }

    protected void setBonusPoints()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        int bonuspoints = int.Parse(Console.ReadLine());
        _bonusPoints = bonuspoints;
    }

    public int getBonusPoints()
    {
        return _bonusPoints;
    }

    public int gettimesCompleted()
    {
        return _timesCompleted;
    }

    public void CreateNewChecklistGoal()
    {
        setName();
        setDescription();
        setPoints();
        setTargetCount();
        setBonusPoints();
    }
    public override string getDisplayString()
    {
        string checkbox = this.getisDone() ? "[X]" : "[ ]";
        return $"{checkbox} {getName()} ({getDescription()}) -- Completed {_timesCompleted}/{_targetCount}";

    }

    public override string getStringForm()
    {
        return $"ChecklistGoal:{getName()},{getDescription()},{getPoints()},{getBonusPoints()},{getTargetCount()},{gettimesCompleted()}";
    }
}