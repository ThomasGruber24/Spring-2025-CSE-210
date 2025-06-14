using System.Diagnostics;

public class Menu
{
    protected void LoadingAnimation(int input, string message = "Now Loading")
    {
        char[] spinner = { '-', '\\', '|', '/' };
        DateTime endTime = DateTime.Now.AddSeconds(input);

        Console.Write(message + " ");
        while (DateTime.Now < endTime)
        {
            foreach (char c in spinner)
            {
                if (DateTime.Now >= endTime) break;

                Console.Write(c);
                Thread.Sleep(100);
                Console.Write("\b");
            }
        }
        Console.WriteLine(); // Move to a new line after animation
    }

    // I learned what switches are from well. ChatGPT, I like to think of it like a physical switch.
    // It takes the input that is inserted into the switch and changes the veriable to that item. in this case string.
    // As I continue I will use switches more often.

    // Side note I knew you could write all in one line but that is really helpful in reducing code.
    protected void Sender(int selection)
    {
        string activity = selection switch
        {
            1 => "breathing",
            2 => "reflection",
            3 => "listing",
            _ => "unknown"
        };

        string defaultText = $"You Selected the {activity} activity.";
        string defaultEndText = "Thank you for participating. Closing program now.";

        if (selection == 1) new Breathing().Caller(defaultText, activity, defaultEndText);
        else if (selection == 2) new Reflection().Caller(defaultText, activity, defaultEndText);
        else if (selection == 3) new Listing().Caller(defaultText, activity, defaultEndText);

        LoadingAnimation(3);
    }

    public void CallSender(int selection)
    {
        Sender(selection);
    }

    protected void DisplayGenericText(string activity)
    {
        Console.WriteLine($"Welcome to {activity}.");
    }

}