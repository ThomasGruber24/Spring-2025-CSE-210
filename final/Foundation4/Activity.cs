public class Activity
{   
    // The main driver for each of these.
    private string date;
    private int minutes;
    // standard date time stuff.
    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public int GetMinutes()
    {
        return minutes;
    }

    public string GetDate()
    {
        return date;
    }

    // These methods are overridden in the derived classes to provide specific implementations for each activity type.
    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{date} Activity ({minutes} min)";
    }
}