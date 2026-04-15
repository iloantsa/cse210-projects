public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)


    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;

    }
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted)
       : base(name, description, points)


    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;

    }

    public override int RecordEvent()
    {

        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        return _points;


    }
    public override bool IsCompleted()
    {

        return _amountCompleted >= _target;


    }

    public override string GetName()
    {
        return _name;


    }
    public override string GetDetailsString()


    {
       

        string check = IsCompleted() ? "[X]" : "[ ]";
        return $"{check} {_name} ({_description}) -- Completed {_amountCompleted}/{_target}";

    }
    public override string GetStringPresentation()
    {


        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}



   