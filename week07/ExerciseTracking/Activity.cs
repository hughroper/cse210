public class Activity
{
    protected string _date;
    protected int _length;

    protected string _name;

    public Activity(string date, int length, string name)
    {
        _date = date;
        _length = length;
        _name = name;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_length} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }

}