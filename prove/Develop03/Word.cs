using System;
using System.Collections.Generic;

public class TextRemover(string scripture, int difficulty)
{
    private string text = scripture;
    private int level = difficulty;

    public string RemoveRandomWords()
    {
        List<string> words = new List<string>(text.Split(new[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries));

        int wordsToRemove = GetWordsToRemove();

        Random rand = new Random();

        for (int i = 0; i < wordsToRemove; i++)
        {
            if (words.Count > 0)
            {
                int indexToRemove = rand.Next(words.Count);
                words.RemoveAt(indexToRemove);
            }
        }

        return string.Join(" ", words);
    }

    private int GetWordsToRemove()
    {
        int wordCount = text.Split(new[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries).Length;

        switch (difficulty)
        {
            case 1:
                return wordCount / 10;
            case 2:
                return wordCount / 5;
            case 3:
                return wordCount / 3;
            default:
                throw new ArgumentException("Invalid difficulty level");
        }
    }
}