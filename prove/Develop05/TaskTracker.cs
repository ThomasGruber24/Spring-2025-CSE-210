public abstract class Task
{
    public string Name { get; }

    protected Task(string name)
    {
        Name = name;
    }

    public abstract int GetPoints(bool completed);
}

class ExerciseTask : Task
{
    public ExerciseTask() : base("Exercise") { }

    public override int GetPoints(bool completed) => completed ? 10 : 0;
}

class ReadingTask : Task
{
    public ReadingTask() : base("Reading") { }

    public override int GetPoints(bool completed) => completed ? 5 : 0;
}

class MealTask : Task
{
    public MealTask() : base("Meal") { }

    public override int GetPoints(bool completed) => completed ? 7 : 0;
}