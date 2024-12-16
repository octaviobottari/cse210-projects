public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Goal '{_shortName}' completed! Earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return IsComplete() ? $"[X] {_shortName}: {_description} - {_points} points" : $"[ ] {_shortName}: {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}: {_description} - {_points} points";
    }
}
