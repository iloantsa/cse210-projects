
public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }
    public override string GetActivityName()
    {
        return "Cycling";
    }
    public override double  GetDistance()
    {

        return _speed * GetDuration()/ 60;
    }
    public override double GetSpeed()
    {
        return _speed; 
        
    }
    public override double GetPace()
    {
        return GetDuration() / GetSpeed();


    }
    
}




