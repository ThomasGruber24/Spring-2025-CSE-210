public class Running : Activity
{
    private double distance;

    // Constructor that initializes the date, minutes, and distance.
    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        this.distance = distance;
    }

    // Here is the override stuff. This is what makes it polymorphic.
    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / GetMinutes()) * 60;
    public override double GetPace() => GetMinutes() / distance;

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}