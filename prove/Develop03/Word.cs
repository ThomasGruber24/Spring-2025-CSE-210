using System;
using System.Collections.Generic;
public static class RandomHelper
{
    public static readonly Random Instance = new Random();
}
public class TextRemover
{
    private string text;
    private int level;

    public TextRemover(string scripture, int difficulty)
    {
        text = scripture;
        level = difficulty;
    }

    public string RemoveRandomWords()
    {
        List<string> words = new List<string>(text.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries));

        int wordsToRemove = GetWordsToRemove(words.Count);

        for (int i = 0; i < wordsToRemove; i++)
        {
            if (words.Count > 0)
            {
                int indexToRemove = RandomHelper.Instance.Next(words.Count);
                words.RemoveAt(indexToRemove);
            }
        }

        return string.Join(" ", words);
    }

    private int GetWordsToRemove(int wordCount)
    {
        int result = level switch
        {
            1 => wordCount / 10,
            2 => wordCount / 5,
            3 => wordCount / 3,
            _ => throw new ArgumentException("Invalid difficulty level")
        };

        return Math.Max(1, result); // Ensure at least one word is removed
    }
}