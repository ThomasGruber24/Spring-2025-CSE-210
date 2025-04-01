public class Breathing : Menu
{
    private void Activity()
    {
        Console.WriteLine("This activity will walk you through breathing steps follow the instructions below. Follow instructions below");
        Console.WriteLine("How many times would you like to go through these steps: ");
        int repititions = int.Parse(Console.ReadLine());
        int counter = 0;
        
        Console.WriteLine("Ready?");
        SleepCounter(3);
        Console.WriteLine("Lets begin");


        do // I simplified the code here
        {
            Console.WriteLine("Breath in for 5 seconds");
            SleepCounter(5);

            Console.WriteLine("Hold in for 5 seconds");
            SleepCounter(5);

            Console.WriteLine("Breath out for 5 seconds");
            SleepCounter(5);

            counter++;
        } while (counter < repititions);
    }

    // Chat GPT explained to me the \b and what it means, its backspace, then I just have a simple for loop
    private void SleepCounter(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Clears previous number
        }
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