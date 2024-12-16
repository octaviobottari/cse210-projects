public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Goal '{_shortName}' progress recorded! {_amountCompleted}/{_target} completed. {_points} points.");

        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Congratulations! You've completed the goal '{_shortName}' and earned {_bonus} bonus points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return IsComplete() ? $"[X] {_shortName}: {_description} - Completed {_amountCompleted}/{_target} times - {_points} points" :
                              $"[ ] {_shortName}: {_description} - Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}: {_description} - {_points} points";
    }
}
