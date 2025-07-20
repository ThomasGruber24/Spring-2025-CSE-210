using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.getTitle("Learning C#");
        video1.getAuthor("John Doe");
        video1.getLength(10, 30); // 10 minutes and 30 seconds

        Comments comments1 = new Comments();
        comments1.addComment("Alice", "Great video!");
        comments1.addComment("Bob", "Very informative.");
        comments1.addComment("Alice", "Thanks for the tips!");
        comments1.addComment("Charlie", "I learned a lot.");

        Console.WriteLine(video1.returnInfo());
        Console.WriteLine(comments1.returnComments());

        Video video2 = new Video();
        video2.getTitle("Advanced C#");
        video2.getAuthor("John Doe");
        video2.getLength(15, 45); // 15 minutes and 45 seconds

        Comments comments2 = new Comments();
        comments2.addComment("Charlie", "This was helpful.");
        comments2.addComment("Alice", "Looking forward to more videos!");
        comments2.addComment("Bob", "Great explanations.");
        comments2.addComment("Thomas", "Have you noticed my Tron references during the semester?");

        Console.WriteLine(video2.returnInfo());
        Console.WriteLine(comments2.returnComments());

        Video video3 = new Video();
        video3.getTitle("C# Careers");
        video3.getAuthor("John Doe");
        video3.getLength(12, 0); // 12 minutes

        Comments comments3 = new Comments();
        comments3.addComment("Alice", "This is a great video!");
        comments3.addComment("Bob", "I love the insights shared here.");
        comments3.addComment("Charlie", "Very useful for my career planning.");
        comments3.addComment("Thomas", "There hasn't been a whole lot of Tron references but theres been a few");

        Console.WriteLine(video3.returnInfo());
        Console.WriteLine(comments3.returnComments());

        Console.WriteLine("End of Line.");
    }
}