public class RecurringGoal : Goal
{
    public RecurringGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"RecurringGoal:{_shortName},{_description},{_points}";
    }

}