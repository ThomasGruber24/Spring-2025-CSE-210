// This is for me to type out what I need to do. It will be saved to a and repeated back to the user while giving a little modivation
using System.Runtime.CompilerServices;

public class TalkThrough : Menu
{
    private void Main()
    {
        bool continueProgram = true;
        Console.WriteLine("Here I will go through a step by step process to help you state the issues you are having");

        while(continueProgram)
        {   
            Console.WriteLine("Please write your worries and press enter when finished");
            string userInput = Console.ReadLine();

            Console.WriteLine($"Heres what you told me: {userInput}, I'm sorry to repeat what you said but I'm a simple program written by a man with ADHD.");
            Console.WriteLine("Try breaking down the task into smaller parts. Thats what the programmer writing this did. He took things one step at a time.");
            Console.WriteLine("What he did was space out the work taking small breaks as he worked. It also helped this assignment was due the day he wrote most of the code.");
            Console.WriteLine("I wont recommend waiting till last moment to do an assignment BUT sometimes that a push for you to do something great!");
            Console.WriteLine("Good luck user! You can do it! Me and the programmer of this simple console program believe in you!");

            Console.WriteLine("Do you want to talk about this again? (yes/no)");
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