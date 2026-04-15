public abstract class Activity
{
    private string _date;
    private double _duration;
    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetDuration()
    {
        return _duration;
    }
    public abstract string GetActivityName();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return ($"{_date} {GetActivityName()} ({_duration}) min- Distance: {GetDistance()} km, Speed: {GetSpeed()} kmph, Pace:{GetPace()} min per km");

    }

}