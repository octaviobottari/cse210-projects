public class Cycling : Activity
{
    public double SpeedKph { get; set; }

    public Cycling(DateTime date, int durationMinutes, double speedKph)
        : base(date, durationMinutes)
    {
        SpeedKph = speedKph;
    }

    public override double GetDistance()
    {
        return SpeedKph * DurationMinutes / 60; 
    }

    public override double GetSpeed()
    {
        return SpeedKph; 
    }

    public override double GetPace()
    {
        return 60 / SpeedKph; 
    }
}
