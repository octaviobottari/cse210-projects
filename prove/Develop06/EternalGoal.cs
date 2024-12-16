public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{_shortName}' progress recorded! Earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false; 
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Ongoing goal";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}: {_description} - {_points} points";
    }
}
