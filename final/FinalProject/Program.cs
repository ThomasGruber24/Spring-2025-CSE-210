using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to preventing ADHD Procrastination!");
        Console.WriteLine("Loading program Menu");
        bool continueProgram = true;

        while (continueProgram)
        {
            Menu start = new Menu();
            start.Entry();

            Console.WriteLine("Do you want to select another section? (yes/no)");
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse != "yes")
            {
                continueProgram = false;
                Console.WriteLine("Exiting program... bye bye!");
            }
        }
    }
}