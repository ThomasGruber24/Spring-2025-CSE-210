using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! What actvity would you like to do today?");
        while (true)
        {
            Console.WriteLine("1 - Breathing Activity\n2 - Reflection Activity\n3 - Listing Activity\n4 - Exit");
            int userInput = int.Parse(Console.ReadLine());
        
            if (userInput < 1 || userInput > 4)
            {
                Console.WriteLine("Invalid input. Please select a valid option.");
                continue;
            }

            if (userInput == 4)
            {
                Console.WriteLine("Goodbye!");
                break; // Exits the loop
            }

        Menu selection = new Menu();
        selection.CallSender(userInput);
        }   
    }



}