using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        TimeSpan currentTime = now.TimeOfDay;

        TimeSpan morningStart = new TimeSpan(5, 0, 0);
        TimeSpan morningEnd = new TimeSpan(10, 59, 59);

        TimeSpan afternoonStart = new TimeSpan(11, 0, 0);
        TimeSpan afternoonEnd = new TimeSpan(17, 59, 59);

        TimeSpan nightStart = new TimeSpan(18, 0, 0);
        TimeSpan nightEnd = new TimeSpan(23, 59, 59);

        TimeSpan invalidStart = new TimeSpan(0, 0, 0);
        TimeSpan invalidEnd = new TimeSpan(4, 59, 59);

        Console.WriteLine("Welcome to The Game.");
        Console.WriteLine("This game will track things that you should already be doing.");
        Console.WriteLine("Here's the list of activities that will gain you points:");
        Console.WriteLine("1: Read Scriptures (100pts)");
        Console.WriteLine("2: Daily Prayer (50pts)(2 times a day)");
        Console.WriteLine("3: Make Your Bed (50pts)");
        Console.WriteLine("4: Brush Your Teeth (50pts)");
        Console.WriteLine("5: Eat Food (33pts)(3 times a day 1 extra point if you do all 3 meals)");
        Console.WriteLine("This totals to 400 points total");

        if (currentTime >= morningStart && currentTime <= morningEnd)
        {
            Console.WriteLine("Good morning! Starting morning tracking");
            TaskTracker MorningTask = new TaskTracker();
            MorningTask.GetMorningTasks();
        }
        else if (currentTime >= afternoonStart && currentTime <= afternoonEnd)
        {
            Console.WriteLine("Good afternoon! Starting afternoon tracking");
            TaskTracker AfternoonTask = new TaskTracker();
            AfternoonTask.GetAfternoonTask();
        }
        else if (currentTime >= nightStart && currentTime <= nightEnd)
        {
            Console.WriteLine("Good evening! Starting night tracking");
            TaskTracker NightTask = new TaskTracker();
            NightTask.GetNightTask();
        }
        else if (currentTime >= invalidStart && currentTime <= invalidEnd)
        {
            Console.WriteLine("Sorry but you cannot participate in today's games. Try again after 5am.");
        }
        else
        {
            Console.WriteLine("Unexpected time. Please check your system clock.");
        }
    }
}