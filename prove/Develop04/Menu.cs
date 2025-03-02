public class Menu
{
    protected void LoadingAnimation(int input)
    {
        char[] spinner = {'-', '\\', '|', '/'};
        DateTime endTime = DateTime.Now.AddSeconds(input);

        Console.WriteLine("Now Loading Activity ");
        while (DateTime.Now < endTime)
        {
            foreach(char c in spinner)
            {
                if (DateTime.Now >= endTime) break;

                Console.Write(c);
                Thread.Sleep(100);
                Console.Write("\b");
            }
        }
    }

    protected void Sender(int selection)
    {
        string activity = "";
        string defaultText = $"You Selected {activity} actvity. ";
        string defaultEndText = "Thank you for participating. Closing program now";
        if (selection == 1)
        {
            activity = "breathing";
            Breathing start = new Breathing();
            start.Caller(defaultText, activity, defaultEndText);
        }
        else if (selection == 2)
        {
            activity = "reflection";
            Reflection start = new Reflection();
            start.Caller(defaultText, activity, defaultEndText);
        }
        else if (selection == 3)
        {
            activity = "listing";
            Listing start = new Listing();
            start.Caller(defaultText, activity, defaultEndText);
        }

        LoadingAnimation(3);
    }

    public void CallSender(int selection)
    {
        Sender(selection);
    }

}