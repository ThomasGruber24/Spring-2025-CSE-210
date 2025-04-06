public class Menu
{
    // This console program is to help modivate with ADHD. 
    public void Entry()
    {
        Console.WriteLine("Please Select what you would like to do");
        Console.WriteLine("Menu:");
        Console.WriteLine("1: Talking Through");
        Console.WriteLine("2: Step By Step");
        Console.WriteLine("3: Break");
        int userSelected = int.Parse(Console.ReadLine());
        Selection(userSelected);
    }
    private void Selection(int userSelected)
    {
        string activity = userSelected switch
        {
            1 => "Talking Through",
            2 => "Step By Step",
            3 => "Break",
            _ => "unknown"
        };
        Console.WriteLine($"Thank you for selecting {activity}, now launching...");
        if (userSelected == 1) new TalkThrough().Caller();
        else if (userSelected == 2) new StepByStep().Caller();
        else if (userSelected == 3) new Break().Caller();
        else
        {
            Console.WriteLine("Error");
        }
        Waiting(3);
    }

    protected void Waiting(int time, string message = "Counting down")
    {
        Console.WriteLine($"{message}:");

    for (int i = time; i >= 0; i--)
    {
        Console.Write($" {i} seconds remaining...   \r");
        Thread.Sleep(1000); // Wait for 1 second
    }
    }
}