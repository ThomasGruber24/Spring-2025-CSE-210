public class Breathing : Menu
{
    private void Activity()
    {
        Console.WriteLine("This activity will walk you through breathing steps follow the instructions below. Follow instructions below");
        Console.WriteLine("How many times would you like to go through these steps: ");
        int repititions = int.Parse(Console.ReadLine());
        int counter = 0;
        
        Console.WriteLine("Ready?");
        Console.WriteLine("3");
        SleepCounter();
        Console.WriteLine("2");
        SleepCounter();
        Console.WriteLine("1");
        SleepCounter();
        Console.WriteLine("Lets begin");


        do
        {
            Console.WriteLine("Breath in for 5 seconds");
            Console.WriteLine("1");
            SleepCounter();
            Console.WriteLine("2");
            SleepCounter();
            Console.WriteLine("3");
            SleepCounter();
            Console.WriteLine("4");
            SleepCounter();
            Console.WriteLine("5");
            SleepCounter();

            Console.WriteLine("Hold in for 5 seconds");
            Console.WriteLine("1");
            SleepCounter();
            Console.WriteLine("2");
            SleepCounter();
            Console.WriteLine("3");
            SleepCounter();
            Console.WriteLine("4");
            SleepCounter();
            Console.WriteLine("5");
            SleepCounter();

            Console.WriteLine("Breath out for 5 seconds");
            Console.WriteLine("1");
            SleepCounter();
            Console.WriteLine("2");
            SleepCounter();
            Console.WriteLine("3");
            SleepCounter();
            Console.WriteLine("4");
            SleepCounter();
            Console.WriteLine("5");
            SleepCounter();

            counter++;
        } while (counter < repititions);
    }

    private void SleepCounter()
    {
        Thread.Sleep(1000);
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