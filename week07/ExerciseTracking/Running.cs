public class Running : Activity
{
    private double _distance;
    public Running(string date, double duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }
    public override string GetActivityName()
    {
        return "Running";
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60;//Kph


    }
    public override double GetPace()
    {
        return GetDuration() / _distance;
    }

}


