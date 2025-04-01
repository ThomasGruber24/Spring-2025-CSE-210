using Microsoft.VisualBasic;
using System;
using System.IO;
public class Journal
{
    private string filePath = "journal.csv";

    public void WriteEntry(string name, string currentDate, string entry)
    {
        string journalEntry = $"{name},\"{currentDate}\",\"{entry}\"";

        File.AppendAllText(filePath, journalEntry + Environment.NewLine);
    }

    public void PrintEntries()
    {
        var lines = File.ReadAllLines(filePath);
        Console.WriteLine("Journal Entries:\n");
        foreach(var line in lines)
        {
            Console.WriteLine(line);
        }
    }

}