public class Video
{
    private string title;
    private string author;
    private int length; // Seconds

    public void getLength(int minutes, int seconds)
    {
        length = (minutes * 60) + seconds;
    }
    public void getTitle(string Title)
    {
        title = Title;
    }
    public void getAuthor(string Author)
    {
        author = Author;
    }
    public string returnInfo()
    {
        return $"Title: {title}, Author: {author}, Length: {length} seconds";
    }

}