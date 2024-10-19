public class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;

    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }
    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public int GetLengthInSeconds()
    {
        return lengthInSeconds;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
        }
        Console.WriteLine();
    }
}