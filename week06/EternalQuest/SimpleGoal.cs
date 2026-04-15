public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isCompleted = false;


    }

    public SimpleGoal(string name, string description, int points, bool isCompleted)
           : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }
    public override bool IsCompleted()
    {
        return _isCompleted;

    }
    public override string GetName()
    {
        return _name;

    }

    public override string GetDetailsString()
    {
        string check = _isCompleted ? "[X]" : "[ ]";
        return $"{check} {_name} ({_description})";
    }
    public override string GetStringPresentation()

    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isCompleted}";


    }
}