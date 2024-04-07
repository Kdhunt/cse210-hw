public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int LengthSeconds { get; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment(commenterName, text);
        comments.Add(comment);
    }

    public int GetNumComments()
    {
        return comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length (seconds): " + LengthSeconds);
        Console.WriteLine("Number of comments: " + GetNumComments());
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments)
        {
            Console.WriteLine("\t"+comment.CommenterName + ": " + comment.Text);
        }
        Console.WriteLine();
    }
}