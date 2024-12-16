public class Running : Activity
{
    public double DistanceMiles { get; set; }

    public Running(DateTime date, int durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        DistanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return DistanceMiles * 1.60934;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationMinutes / GetDistance();
    }
}
