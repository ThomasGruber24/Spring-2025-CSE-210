public class Reflection : Menu
{
    private void Activity()
    {
        Console.WriteLine("This activiy will help you relflect on your life, you will have 30 seconds to think of an answer for the first question. Then you will have 8 for each following question");
        Random random = new Random();
        int ranSel = random.Next(0,3);
        if (ranSel == 0)
        {
            Console.WriteLine("Think of a time when you stood up for someone else.");
        }
        else if (ranSel == 1)
        {
            Console.WriteLine("Think of  atime when you did something really difficult.");
        }
        else if (ranSel == 2)
        {
            Console.WriteLine("Think of a time when you helped someone in need.");
        }
        else
        {
            Console.WriteLine("Think of a time when you did something truly selfless.");
        }

        LoadingAnimation(30);

        Console.WriteLine("Why did you think of this experiance?");
        LoadingAnimation(8, "Thinking...");

        Console.WriteLine("How did this experiance start?");
        LoadingAnimation(8, "Thinking...");

        Console.WriteLine("What did you learn about yourself?");
        LoadingAnimation(8, "Thinking...");

        Console.WriteLine("Lastly, How can you keep this experience in mind in the future?");
        LoadingAnimation(8, "Thinking...");
    }
    public void Caller(string defaultText, string activity, string defaultEndText)
    {   
        Console.WriteLine(defaultText);
        LoadingAnimation(3);
        Activity();
        Console.WriteLine(defaultEndText);
        LoadingAnimation(3);
    }
}