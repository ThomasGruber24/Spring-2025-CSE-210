using System;
using System.Collections;


public class ScriptureSelector(int scDifficulty)
{
    public string Scripture()
    {
        Random rand = new Random();
        int randomSelection = rand.Next(1,4);
        int scriptureDifficulty = scDifficulty;

        return SelectedScripture(scriptureDifficulty, randomSelection);
    }

    private string SelectedScripture(int scriptureDifficulty, int randomSelection)
    {
        switch ()
        {
            case 1:
                return "place";
            case 2:
                return "place";
            case 3:
                return "place";
        }
    }
}