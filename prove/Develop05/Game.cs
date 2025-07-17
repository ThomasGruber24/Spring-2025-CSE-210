using Microsoft.Win32.SafeHandles;

public class Game
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void Run()
    {
        bool exit = false;

        while (exit == false)
        {
            Console.WriteLine($"\nCurrent Score: {score}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                CreateGoal();
            }
            else if (input == "2")
            {
                ListGoals();
            }
            else if (input == "3")
            {
                RecordEvent();
            }
            else if (input == "4")
            {
                SaveGoals();
            }
            else if (input == "5")
            {
                LoadGoals();
            }
            else if (input == "6")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("invalid input.");
            }

        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Choose Goal Type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Enter in selection: ");
        string choice = Console.ReadLine();
        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Points you'd like to have with this goal: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            goals.Add(new SimpleGoal(name, points));
        }
        else if (choice == "2")
        {
            goals.Add(new EternalGoal(name, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter times needed to complete: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, points, targetCount, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal to record progress: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.ToCSV());
            }
        }

        Console.WriteLine("Goals saved!");
    }

    private void LoadGoals()
    {
        if (File.Exists("goals.txt") == false)
        {
            Console.WriteLine("No save file found.");
            return;
        }

        goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            Goal g = Goal.FromCSV(lines[i]);
            if (g != null) goals.Add(g);
        }

        Console.WriteLine("Goals loaded!");
    }
}