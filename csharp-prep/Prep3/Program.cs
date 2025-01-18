using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);

        int numberOfGuesses = 0;

        bool end = false;

        while (end == false)
        {
            Console.WriteLine("What is your guess?");
            string stGuess = Console.ReadLine();
            int guess = int.Parse(stGuess);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
                numberOfGuesses++;
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
                numberOfGuesses++;
            }

            else
            {
                Console.WriteLine("You guessed it!");
                numberOfGuesses++;
                Console.WriteLine($"Number of guesses {numberOfGuesses}");
                end = true
            }
        }
    }
}