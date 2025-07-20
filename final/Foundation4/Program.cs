using System;

class Program
{
    static void Main(string[] args)
    {
        // This is the main reason I chose to do this project. Im having trouble with polymorphism. I did use chatGPT as a crutch during this assignment
        // to make up for this I will be writing comments explaining the code and how it works. Also couldnt really work in any tron references ;-;

        // So this creates the activity dictionary that will hold each of the activities.
        List<Activity> activities = new List<Activity>();

        // here is the different activities. dates minutes and speed.
        activities.Add(new Running("07/19/2025", 30, 3.0));
        activities.Add(new Cycling("07/20/2025", 45, 15.0));
        activities.Add(new Swimming("07/21/2025", 30, 20));

        // runs through each item in the dictionary.
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}