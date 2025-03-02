using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! What actvity would you like to do today?");
        Console.WriteLine("1 - Breathing Activity\n2 - Reflection Activity\n3 - Listing Activity");
        int userInput = int.Parse(Console.ReadLine());

        if (userInput >= 1 || userInput <= 3) // Apparently from chatGPT || means AND in bool but simpler
        {
            Menu selection = new Menu();
            selection.CallSender(userInput);
        }
        else
        {
            Console.WriteLine("Please input a valid input.");
        }
    }
}