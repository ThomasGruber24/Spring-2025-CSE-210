using System.Runtime.CompilerServices;

public class TextRemover(string scripture, int difficulty)
{
    private string scripture = scripture;
    private int difficulty = difficulty;
    public string ReturnDeletedText()
    {
        return RemoveText(scripture, difficulty);
    }
    private string RemoveText(string scripture, int difficulty)
    {
        string editedScripture = scripture;

        if (difficulty == 1)
        {
            foreach (string word in scripture.Split(' '))
            {
                // This is something AI gave me to help with errors. IsNullOrWiteSpace is as it discribes if the word is puncuation it skips it
                if (string.IsNullOrWhiteSpace(word)) continue;

                if (word.Length <= 3)
                {
                    // AI helped me through this code (same with the other 3 spots)
                    string replacement = string.Join(" ", new string('_', word.Length).ToCharArray());
                    editedScripture = editedScripture.Replace(word, replacement);
                }
            }
        }
        else if (difficulty == 2)
        {
            int removed = 0;
            foreach (string word in scripture.Split(' '))
            {
                if (string.IsNullOrWhiteSpace(word)) continue;

                if (word.Length >= 4 && word.Length <= 6 && removed < 4)
                {
                    string replacement = string.Join(" ", new string('_', word.Length).ToCharArray());
                    editedScripture = editedScripture.Replace(word, replacement);
                    removed++;
                }
            }
        }
        else if (difficulty == 3)
        {
            foreach (string word in scripture.Split(' '))
            {
                if (string.IsNullOrWhiteSpace(word)) continue;

                if (word.Length >= 4)
                {
                    string replacement = string.Join(" ", new string('_', word.Length).ToCharArray());
                    editedScripture = editedScripture.Replace(word, replacement);
                }
            }
        }

        return editedScripture;
    }

}