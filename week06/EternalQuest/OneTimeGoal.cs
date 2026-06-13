public class OneTimeGoal : Goal
{

    private bool _isComplete;

    public OneTimeGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public OneTimeGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status;

        if (_isComplete)
        {
            status = "X";
        }
        else
        {
            status = " ";
        }
        return $"[{status}] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"OneTimeGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

}