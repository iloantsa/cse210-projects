public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double duration, int laps)
        : base(date, duration)
    {
        _laps = laps;

    }
    public override string GetActivityName()
    {
        return "Swimming";
    }
    public override double GetDistance()
    {
        return (_laps * 50) / 1000; //km

    }
    public override double  GetSpeed()
    {
        return GetDistance()* GetDuration() *60;

    }
    public override double  GetPace()
    {
        return GetDuration() / GetDistance();

    }
    
}

