public class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    // This is a bit more complicated polymorphic stuff. but its doing all the math stuff that is needed for this part of the program.
    public override double GetDistance()
    {
        return (laps * 50) / 1000.0 * 0.62; // meters to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetMinutes()} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}