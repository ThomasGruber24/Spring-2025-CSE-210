public class Cycling : Activity
{
    private double speed;

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    // again polymorphic stuff.
    public override double GetSpeed() => speed;
    public override double GetDistance() => (speed * GetMinutes()) / 60;
    public override double GetPace() => 60 / speed;

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetMinutes()} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}