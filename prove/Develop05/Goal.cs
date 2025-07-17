// I'm keeping anything related to Goal in this file instead of making new files. This is just so I can work with them easier and treat it more like functions/meathods.
public abstract class Goal
{
    public string Name;
    public int Points;

    protected Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string ToCSV();
    public static Goal FromCSV(string line)
    {
        var parts = line.Split(',');
        // I know through these if statements I can use switch cases, but I am unfamiliar with them so I stuck with if statements.
        // Using AI assistants they tend to have me use switch cases but again, not comfortable with them yet to use them so I am using an if tree.
        if (parts[0] == "Simple")
        {
            return new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
        }
        else if (parts[0] == "Eternal")
        {
            return new EternalGoal(parts[1], int.Parse(parts[2]));
        }
        else if (parts[0] == "Checklist")
        {
            return new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
        }
        else
        {
            return null;
        }
    }
}

public class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, int points, bool completed = false) : base(name, points)
    {
        this.completed = completed;
    }

    public override int RecordEvent()
    {
        if (completed == false)
        {
            completed = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus() => $"[{"X", -1}] {Name}";
    public override string ToCSV() => $"Simple,{Name},{Points},{completed}";
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent() => Points;
    public override string GetStatus() => $"[Unlimited] {Name}";
    public override string ToCSV() => $"Eternal,{Name},{Points}";
}

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonus;

    public ChecklistGoal(string name, int points, int targetCount, int bonus, int currentCount = 0)
        : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonus = bonus;
        this.currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            if (currentCount == targetCount)
                return Points + bonus;
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string check = currentCount >= targetCount ? "X" : " ";
        return $"[{check}] {Name} -- Completed {currentCount}/{targetCount} times";
    }

    public override string ToCSV() => $"Checklist,{Name},{Points},{targetCount},{bonus},{currentCount}";
}