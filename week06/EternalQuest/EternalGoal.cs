public class EternalGoal:Goal
{


    public EternalGoal(string name, string description, int points)
        :base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;

    }
    public override bool IsCompleted()
    {
        return false;

    }

    public override string GetName()
    {
        return _name;

    }    



    public override string GetDetailsString()
    {
        return ($"[] {_name} ({_description})");

    }
    public override string GetStringPresentation()
    {
        return ($"EternalGoal {_name} {_description} {_points}");

    }
}