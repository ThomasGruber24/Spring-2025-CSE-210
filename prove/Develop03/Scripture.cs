using System;
using System.Collections;


public class ScriptureSelector
{
    private int scriptureDifficulty;

    public ScriptureSelector(int scDifficulty)
    {
        scriptureDifficulty = scDifficulty;
    }

    public string Scripture()
    {
        Random rand = new Random();
        int randomSelection = rand.Next(1, 4); // not used in your example, but could be expanded for variety
        return SelectedScripture(scriptureDifficulty, randomSelection);
    }

    private string SelectedScripture(int scriptureDifficulty, int randomSelection)
    {
        switch (scriptureDifficulty)
        {
            case 1:
                return "Look unto me in every thought; doubt not, fear not.";
            case 2:
                return "No man can serve two masters: for either he will hate the one, and love the other; or else he will hold to the one, and despise the other. Ye cannot serve God and mammon.";
            case 3:
                return "This book of the law shall not depart out of thy mouth; but thou shalt meditate therein day and night, that thou mayest observe to do according to all that is written therein: for then thou shalt make thy way prosperous, and then thou shalt have good success.";
            default:
                return "Invalid difficulty.";
        }
    }
}