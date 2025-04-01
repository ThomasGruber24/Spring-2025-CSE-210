// I had issues with this one and ChatGPT helped me a whole lot with it.
public class Listing : Menu
{
    private void Activity()
    {
        Console.WriteLine("This will help you make a list of a few different things that mean a lot to you.");
        Console.WriteLine("You will have 1 minute to write the list");

        int duration = 60;

        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine("\nThink about the following prompt:");
        Console.WriteLine($"\"{selectedPrompt}\"");
        Console.WriteLine("Prepare to start listing your answers...");

        // Placeholder for countdown or wait time
        // You will handle the actual wait time logic here

        Console.WriteLine("\nStart listing your answers. Press Enter after each one.");
        Console.WriteLine("Press Enter without typing anything to stop.");

        List<string> userResponses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.WriteLine("\nStart listing your answers. Press Enter after each one.");
        while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    string response = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(response))
                    {
                        userResponses.Add(response);
                    }
                }
            }


        Console.WriteLine($"\nYou listed {userResponses.Count} items!");
        Console.WriteLine("Thank you for participating in the Reflection Activity.");
    }
    public void Caller(string defaultText, string activity, string defaultEndText)
    {   
        Console.WriteLine(defaultText);
        LoadingAnimation(3);
        Activity();
        Console.WriteLine(defaultEndText);
        LoadingAnimation(3);
    }
}