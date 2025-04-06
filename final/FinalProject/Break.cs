// This will basically be a timer that runs to give me a break. Like a phone alarm.
public class Break : Menu
{
    private void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("In this section, you will have a timed break. The console will beep at you when finished.");
            
            Console.WriteLine("How many minutes is your break going to be?");
            int waitTime = int.Parse(Console.ReadLine());
            int waitTimeinSeconds = waitTime * 60;

            Waiting(waitTimeinSeconds);
            
            Console.WriteLine("Timer is done. Please start your work again.");
            Console.Beep(800, 1000); // Beep to indicate the break is over

            Console.WriteLine("Do you want to take another break? (yes/no)");
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse != "yes")
            {
                continueProgram = false;
                Console.WriteLine("Exiting break session...");
            }
        }
    }
    public void Caller()
    {
        Main();
    }
}