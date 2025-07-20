public class Comments
{
    private Dictionary<string, string> CommentList = new Dictionary<string, string>(); //The first string is the username, the second is the comment text. I thought of doing this instead of a list.

    public void addComment(string username, string commentText)
    {
        if (CommentList.ContainsKey(username) == false)
        {
            CommentList[username] = commentText;
        }
        else
        {
            CommentList[username] += "\n" + commentText;
        }
    }

    public string returnComments()
    {
        string allComments = "";
        foreach (var comment in CommentList)
        {
            allComments += $"{comment.Key}: {comment.Value}\n";
        }
        return allComments.TrimEnd('\n'); // Remove the last newline character, Chat GPT taught me this one.
    }
}
