using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assigntment1 = new Assignment("Samual Bennett", "Multiplication");
        Console.WriteLine(assigntment1.GetSummary());

        MathAssigment assigment2 = new MathAssigment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assigment2.GetSummary());
        Console.WriteLine(assigment2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}