public class Points
{
    protected int totalPoints = 0;

    public void AddPoints(int points)
    {
        totalPoints += points;
        Console.WriteLine($"+{points} points! Total: {totalPoints} points.");
    }

    public void ShowTotalPoints()
    {
        Console.WriteLine($"You have earned {totalPoints} points today!");
    }
}