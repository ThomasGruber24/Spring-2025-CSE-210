using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Would you like to write a new entry or view previous ones? (1 - new entery, 2 - view previous entries)");
        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            string currentDate = DateTime.Now.ToString("MM-dd-yyyy");

            Prompt promptGenerator = new Prompt();
            Console.WriteLine("Here is your prompt");
            Console.WriteLine(promptGenerator.GetRandomPrompt());
            string entry = Console.ReadLine();

            Journal journalEntry = new Journal();

            journalEntry.WriteEntry(name, currentDate, entry);
            Console.WriteLine("recorded");
        }
        else
        {
            Journal loadEntry = new Journal();

            loadEntry.PrintEntries();
        }

    }
}