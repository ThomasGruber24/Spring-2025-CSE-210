public class Journal
{
    private string filePath = "journal.csv";

    public void WriteEntry(string name, string currentDate, string entry)
    {
        string journalEntry = $"{name},\"{currentDate}\",\"{entry}\"";

        File.AppendAllText(filePath, journalEntry + Environment.NewLine);
    }

}