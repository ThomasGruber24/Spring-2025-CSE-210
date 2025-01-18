using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        bool end = false;

        while (end == false)
        {
            Console.Write("Entered Number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (input == 0)
            {
                end = true;
            }
            else
            {
                numbers.Add(number);
            }
        }

        int total = 0;
        int biggestNumber = 0;

        foreach(int number in numbers)
        {
            total = total + number;

            if (number >= biggestNumber)
            {
                biggestNumber = number;
            }
        }

        float average = (float)flTotal / (float)numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {biggestNumber}");
    }
}