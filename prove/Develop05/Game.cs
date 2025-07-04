public class Game
{
    private List<Task> tasks = new List<Task>
    {
        new ExerciseTask(), new ReadingTask(), new MealTask()
    };

    public void Start()
    {
        int totalPoints = 0;

        Console.WriteLine("Welcome to the Task Tracker");

        foreach (var task in tasks)
        {
            Console.WriteLine($"Did you complete {task.Name} (T/F): ");
            string input = Console.ReadLine();

            bool completed = (input == "T");
            int points = task.GetPoints(completed);

            Console.WriteLine($"You earned {points} points for {task.Name}");
            totalPoints += points;
        }

        Console.WriteLine($"Total points earned today: {totalPoints}");
    }
}