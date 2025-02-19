using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter in the difficulty of scripture you would like. (1 - Easy 2 - Medium 3 - Hard)");
        int scriptureDifficulty = int.Parse(Console.ReadLine());

        Console.WriteLine("Ender difficulty level of Memorization. (1 - Easy 2 - Medium 3 - Hard)");
        int memorizationDifficulty = int.Parse(Console.ReadLine());

        ScriptureSelector text = new ScriptureSelector(scriptureDifficulty);
        string scripture = text.Scripture();

        TextRemover challengeText = new TextRemover(scripture, memorizationDifficulty);
        string challengeScripture = challengeText.RemoveRandomWords();

        Console.WriteLine("\nModified Text:");
        Console.WriteLine(challengeScripture);
    }
}