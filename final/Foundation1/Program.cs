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
    }
}