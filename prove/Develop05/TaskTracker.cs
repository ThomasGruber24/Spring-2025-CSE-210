public class TaskTracker : Points
{
    public void GetMorningTasks()
    {
        MorningTaskTracker();
        ShowTotalPoints();
    }

    public void GetAfternoonTask()
    {
        AfternoonTaskTracker();
        ShowTotalPoints();
    }

    public void GetNightTask()
    {
        NightTaskTracker();
        ShowTotalPoints();
    }

    private void MorningTaskTracker()
    {
        Console.WriteLine("Did you pray (1/2) today? (y/n)");
        string response = Console.ReadLine();
        if (response == "y") AddPoints(50);

        Console.WriteLine("Did you brush your teeth (1/2) today? (y/n)");
        response = Console.ReadLine();
        if (response == "y") AddPoints(50);

        Console.WriteLine("Did you make your bed? (y/n)");
        response = Console.ReadLine();
        if (response == "y") AddPoints(50);

        Console.WriteLine("Did you eat food (1/3)? (y/n)");
        response = Console.ReadLine();
        if (response == "y") AddPoints(33);
    }

    private void AfternoonTaskTracker()
    {
        Console.WriteLine("Did you eat food (2/3)? (y/n)");
        string response = Console.ReadLine();
        if (response == "y") AddPoints(33);
    }

    private void NightTaskTracker()
    {
        Console.WriteLine("Did you pray (2/2)? (y/n)");
        string response = Console.ReadLine();
        if (response == "y") AddPoints(50);
    
        Console.WriteLine("Did you brush your teeth (2/2)? (y/n)");
        response = Console.ReadLine();
        if (response == "y") AddPoints(50);
    
        Console.WriteLine("Did you eat food (3/3)? (y/n)");
        response = Console.ReadLine();
        bool ateThirdMeal = false;
        if (response == "y")
        {
            AddPoints(33);
            ateThirdMeal = true;
        }
        Console.WriteLine("Did you eat all 3 meals today? (y/n)");
        response = Console.ReadLine();
        if (response == "y" && ateThirdMeal)
        {
            AddPoints(1);
        }
    }
}
