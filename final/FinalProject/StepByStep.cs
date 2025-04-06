// This will go through a step by step process to get me back on track
public class StepByStep : Menu
{
    private void Main()
    {
        bool continueProgram = true;
        Console.WriteLine("In this section I will go through some steps to get back on track");

        while(continueProgram)
        {
            Console.WriteLine("You be here has helped you complete step one. Acknowledge and Accpet you are off track. Thats ok! Lets get you back on track");
            Thread.Sleep(5000);

            Console.WriteLine("I recommend after this excosize go to the talk through section and complete that.");
            Thread.Sleep(5000);
            
            Console.WriteLine("Prioritize and set clear goals set in the talk through section.");
            Thread.Sleep(5000);

            Console.WriteLine("In the future lets try to create a routine.");
            Thread.Sleep(5000);

            Console.WriteLine("Limit Distractions while also listening to music.");
            Thread.Sleep(5000);

            Console.WriteLine("Maybe try out the break section. Take short breaks to allow yourself to be distracted");
            Thread.Sleep(5000);

            Console.WriteLine("Reward Yourself when you complete the goals!");
            Thread.Sleep(5000);

            Console.WriteLine("Take care of yourself and again, take breaks!");
            Thread.Sleep(5000);

            Console.WriteLine("If none has helped so far look for somebody to help put you back on tast.");
            Thread.Sleep(5000);

            Console.WriteLine("Self reflect and adjust your habits regularly.");
            Thread.Sleep(5000);

            Console.WriteLine("You can do it!!!");
            Thread.Sleep(5000);            

            Console.WriteLine("Do you want to go through the step by step process again? (yes/no)");
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