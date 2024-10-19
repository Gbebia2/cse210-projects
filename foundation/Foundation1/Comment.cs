public class Comment
{
    private string name;
    private string text;

    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }

    public string GetName()
    {
        return name;
    }

    public string GetText()
    {
        return text;
    }
}