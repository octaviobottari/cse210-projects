public class Swimming : Activity
{
    public int Laps { get; set; }


    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0; 
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
